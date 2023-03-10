using Common.Repositories;
using DAL.Entities;
using DAL.Mapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class ReservationService : BaseService, IReservationRepository<Reservation, int>
    {
        public ReservationService(IConfiguration config) : base(config, "ECOTRAVEL-DB")
        {
        }

        public IEnumerable<Reservation> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idReservation], [checkIn], [checkOut], [adulte], [enfant], [assurance], [dateAnnulation], [annulationProprietaire], [idIndisponible], [idLogement], [idClient] FROM [Reservation]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToReservation();
                        }
                    }
                }
            }
        }

        public Reservation Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idReservation], [checkIn], [checkOut], [adulte], [enfant], [assurance], [dateAnnulation], [annulationProprietaire], [idIndisponible], [idLogement], [idClient] FROM [Reservation] WHERE [idReservation] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToReservation();
                        return null;
                    }
                }
            }
        }

        public int Insert(Reservation entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    /* command.CommandText = @"INSERT INTO [Client] ([CliName], [CliFirstName], [CliMail], [CliCompany], [CliLogin], [CliPassword])
                         OUTPUT [inserted].[idClient]
                         VALUES (@CliNam, @CliFirstName, @CliMail, @CliCompany, @CliLogin, HASHBYTES('SHA2_512, @CliPassword)";*/


                    command.CommandText = "SP_ReservationAdd";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("checkIn", entity.ResCheckIn);
                    command.Parameters.AddWithValue("checkOut", entity.ResCheckOut);
                    command.Parameters.AddWithValue("adulte", entity.ResAdulte);
                    command.Parameters.AddWithValue("enfant", entity.ResEnfant);
                    command.Parameters.AddWithValue("assurance", entity.ResAssurance);
                    command.Parameters.AddWithValue("dateAnnulation", entity.ResDateAnnulation);
                    command.Parameters.AddWithValue("annulationProprietaire", entity.ResAnnulationProprietaire);
                    command.Parameters.AddWithValue("idIndiponible", entity.idIndisponible);
                    command.Parameters.AddWithValue("idClient", entity.idClient);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Reservation entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Reservation]
                                            SET [checkIn] = @ResCheckIn,
                                                [checkOut] = @ResCheckOut,
                                                [adulte] = @ResAdulte,
                                                [enfant] = @ResEnfant,
                                                [assurance] = @ResAssurance,
                                                [annulationProprietaire] = @ResAnnulationProprietaire
                                                [IdIndisponible] = @IdIndisponible,
                                                [idLogement] = @idLogement,
                                                [idClient] = @idClient
                                            WHERE [idClient] = @id";
                    command.Parameters.AddWithValue("checkIn", entity.ResCheckIn);
                    command.Parameters.AddWithValue("checkOut", entity.ResCheckOut);
                    command.Parameters.AddWithValue("adulte", entity.ResAdulte);
                    command.Parameters.AddWithValue("enfant", entity.ResEnfant);
                    command.Parameters.AddWithValue("assurance", entity.ResAssurance);
                    command.Parameters.AddWithValue("dateAnnulation", entity.ResDateAnnulation);
                    command.Parameters.AddWithValue("annulationProprietaire", entity.ResAnnulationProprietaire);
                    command.Parameters.AddWithValue("idIndiponible", entity.idIndisponible);
                    command.Parameters.AddWithValue("idClient", entity.idClient);
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
                    command.CommandText = "DELETE FROM [Reservation] WHERE [idReservation] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        //PAS LE TEMPS DE CHECK COMMENT FAIRE | A LA BOURRE :(
        public IEnumerable<Reservation> GetByClient(int idClient)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetByDate(DateTime date)
        {
            throw new NotImplementedException();
        }
    }

}
