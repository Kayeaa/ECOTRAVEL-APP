using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Repositories;
using DAL.Mapper;
using DAL.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DAL.Services
{
    public class AvisService : BaseService, IAvisRepository<Avis, int>
    {
        public AvisService(IConfiguration config) : base(config, "ECOTRAVEL-DB")
        {
        }


        public Avis Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idAvis], [note], [idLogement], [idClient], [message] FROM [Avis] WHERE [idAvis] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToAvis();
                        return null;
                    }
                }
            }
        }

        public int Insert(Avis entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    /* command.CommandText = @"INSERT INTO [Client] ([CliName], [CliFirstName], [CliMail], [CliCompany], [CliLogin], [CliPassword])
                         OUTPUT [inserted].[idClient]
                         VALUES (@CliNam, @CliFirstName, @CliMail, @CliCompany, @CliLogin, HASHBYTES('SHA2_512, @CliPassword)";*/


                    command.CommandText = "SP_AvisAdd";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("note", entity.AvisNotes);
                    command.Parameters.AddWithValue("idLogement", entity.idLogement);
                    command.Parameters.AddWithValue("idlient", entity.idClient);
                    command.Parameters.AddWithValue("message", entity.AvisMessage);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Avis] WHERE [idAvis] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        //Le but est de ne pas pouvoir modifier ou faire une recherche de tout les avis.

        public IEnumerable<Avis> Get()
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Avis entity)
        {
            throw new NotImplementedException();
        }
    }
}
