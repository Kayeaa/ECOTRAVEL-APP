using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Repositories;
using DAL.Mapper;
using DAL.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DAL.Services
{
    public class ClientService : BaseService, IClientRepository<Client, int>
    {
        public ClientService(IConfiguration config) : base(config, "ECOTRAVEL-DB")
        {
        }

        public IEnumerable<Client> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idClient], [nom], [prenom], [email], [pays], [telephone] FROM [Client]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToClient();
                        }
                    }
                }
            }
        }

        public Client Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idClient], [nom], [prenom], [email], [pays], [telephone] FROM [Client] WHERE [idClient] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToClient();
                        return null;
                    }
                }
            }
        }

        public int Insert(Client entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    /* command.CommandText = @"INSERT INTO [Client] ([CliName], [CliFirstName], [CliMail], [CliCompany], [CliLogin], [CliPassword])
                         OUTPUT [inserted].[idClient]
                         VALUES (@CliNam, @CliFirstName, @CliMail, @CliCompany, @CliLogin, HASHBYTES('SHA2_512, @CliPassword)";*/


                    command.CommandText = "SP_ClientAdd";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("nom", entity.CliNom);
                    command.Parameters.AddWithValue("prenom", entity.CliPrenom);
                    command.Parameters.AddWithValue("email", entity.CliEmail);
                    command.Parameters.AddWithValue("pays", entity.CliPays);
                    command.Parameters.AddWithValue("telephone", entity.CliTelephone);
                    command.Parameters.AddWithValue("pass", entity.CliPassword);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Client entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Client]
                                            SET [nom] = @CliNom,
                                                [prenom] = @CliPrenom,
                                                [email] = @CliEmail,
                                                [pays] = @CliPays,
                                                [telephone] = @CliTelephone,
                                                [password] = @CliPassword
                                            WHERE [idClient] = @id";
                    command.Parameters.AddWithValue("nom", entity.CliNom);
                    command.Parameters.AddWithValue("prenom", entity.CliPrenom);
                    command.Parameters.AddWithValue("email", entity.CliEmail);
                    command.Parameters.AddWithValue("pays", entity.CliPays);
                    command.Parameters.AddWithValue("telephone", entity.CliTelephone);
                    command.Parameters.AddWithValue("pass", entity.CliPassword);
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Client] WHERE [idClient] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public int? CheckPassword(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_ClientCheck";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("pass", password);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return (result is DBNull) ? null : (int?)result;
                }
            }
        }
    }

}
