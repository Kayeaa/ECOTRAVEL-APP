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
    public class LogementService : BaseService, ILogementRepository<Logement, int>
    {
        public LogementService(IConfiguration config) : base(config, "ECOTRAVEL-DB")
        {
        }

        public IEnumerable<Logement> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idLogement], [nom], [boite], [numero], [rue], [pays], [coordLatitude], [coordLongitude], [desciptionCourte], [descriptionLongue], [chambre], [piece], [capacite], [salledeBain], [wc], [balcon], [airConcitionne], [wifi], [minibar], [animaux], [piscine], [voiturier], [roomService], [idTypeLogement], [idProprietaire] FROM [Logement]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }

        public Logement Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idLogement], [nom], [boite], [numero], [rue], [pays], [coordLatitude], [coordLongitude], [desciptionCourte], [descriptionLongue], [chambre], [piece], [capacite], [salledeBain], [wc], [balcon], [airConcitionne], [wifi], [minibar], [animaux], [piscine], [voiturier], [roomService], [idTypeLogement], [idProprietaire] FROM [Logement] WHERE [idLogement] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToLogement();
                        return null;
                    }
                }
            }
        }

        public int Insert(Logement entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    /* command.CommandText = @"INSERT INTO [Client] ([CliName], [CliFirstName], [CliMail], [CliCompany], [CliLogin], [CliPassword])
                         OUTPUT [inserted].[idClient]
                         VALUES (@CliNam, @CliFirstName, @CliMail, @CliCompany, @CliLogin, HASHBYTES('SHA2_512, @CliPassword)";*/


                    command.CommandText = "SP_LogementAdd";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("nom", entity.LogNom);
                    command.Parameters.AddWithValue("boite", entity.LogBoite);
                    command.Parameters.AddWithValue("numero", entity.LogNum);
                    command.Parameters.AddWithValue("rue", entity.LogRue);
                    command.Parameters.AddWithValue("pays", entity.LogPays);
                    command.Parameters.AddWithValue("coordLatitude", entity.LogCoorLatitude);
                    command.Parameters.AddWithValue("coordLongitude", entity.LogCoorLongitude);
                    command.Parameters.AddWithValue("descriptionCourte", entity.LogDescriptionCourte);
                    command.Parameters.AddWithValue("descriptionLongue", entity.LogDescriptionLongue);
                    command.Parameters.AddWithValue("chambre", entity.LogChambre);
                    command.Parameters.AddWithValue("piece", entity.LogPiece);
                    command.Parameters.AddWithValue("capacite", entity.LogCapacite);
                    command.Parameters.AddWithValue("salledeBain", entity.LogSalledeBain);
                    command.Parameters.AddWithValue("wc", entity.LogWc);
                    command.Parameters.AddWithValue("balcon", entity.LogBalcon);
                    command.Parameters.AddWithValue("airConditionne", entity.LogAirConditionne);
                    command.Parameters.AddWithValue("wifi", entity.LogWifi);
                    command.Parameters.AddWithValue("minibar", entity.LogMinibar);
                    command.Parameters.AddWithValue("animaux", entity.LogAnimaux);
                    command.Parameters.AddWithValue("piscine", entity.LogPiscine);
                    command.Parameters.AddWithValue("voiturier", entity.LogVoiturier);
                    command.Parameters.AddWithValue("roomService", entity.LogRoomService);
                    command.Parameters.AddWithValue("idLogement", entity.idTypeLogement);
                    command.Parameters.AddWithValue("idProprietaire", entity.idProprietaire);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Logement entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Client]
                                            SET [nom] = @LogNom,
                                                [boite] = @LogBoite
                                                [numero] = @LogNum,
                                                [rue] = @LogRue,   
                                                [pays] = @LogPays,
                                                [coordLatitude] = @LogCoordLatitude,
                                                [coordLongitude] = @LogCoordLongitude,
                                                [descriptionCourte] = @LogDescriptionCourte
                                                [coordLongitude] = @LogCoordLongitude,
                                                [descriptionCourte] = @LogDescriptionCourte
                                                [descriptionLongue] = @LogDescriptionLongue
                                                [chambre] = @LogChambre,   
                                                [piece] = @LogPiece,
                                                [capacite] = @LogCapacite,   
                                                [salledeBain] = @LogSalledeBain,
                                                [wc] = @LogWc,   
                                                [balcon] = @LogBalcon,
                                                [airConditionne] = @LogAirConditionne,
                                                [wifi] = @LogWifi,
                                                [minibar] = @LogMinibar,
                                                [animaux] = @LogAnimaux,   
                                                [piscine] = @LogPiscine,
                                                [voiturier] = @LogVoiturier,
                                                [idTypeLogement] = @LogTypeLogement,
                                                [idProprietaire] = @LogProprietaire

                                            WHERE [idLogement] = @id";

                    command.Parameters.AddWithValue("nom", entity.LogNom);
                    command.Parameters.AddWithValue("boite", entity.LogBoite);
                    command.Parameters.AddWithValue("numero", entity.LogNum);
                    command.Parameters.AddWithValue("rue", entity.LogRue);
                    command.Parameters.AddWithValue("pays", entity.LogPays);
                    command.Parameters.AddWithValue("coordLatitude", entity.LogCoorLatitude);
                    command.Parameters.AddWithValue("coordLongitude", entity.LogCoorLongitude);
                    command.Parameters.AddWithValue("descriptionCourte", entity.LogDescriptionCourte);
                    command.Parameters.AddWithValue("descriptionLongue", entity.LogDescriptionLongue);
                    command.Parameters.AddWithValue("chambre", entity.LogChambre);
                    command.Parameters.AddWithValue("piece", entity.LogPiece);
                    command.Parameters.AddWithValue("capacite", entity.LogCapacite);
                    command.Parameters.AddWithValue("salledeBain", entity.LogSalledeBain);
                    command.Parameters.AddWithValue("wc", entity.LogWc);
                    command.Parameters.AddWithValue("balcon", entity.LogBalcon);
                    command.Parameters.AddWithValue("airConditionne", entity.LogAirConditionne);
                    command.Parameters.AddWithValue("wifi", entity.LogWifi);
                    command.Parameters.AddWithValue("minibar", entity.LogMinibar);
                    command.Parameters.AddWithValue("animaux", entity.LogAnimaux);
                    command.Parameters.AddWithValue("piscine", entity.LogPiscine);
                    command.Parameters.AddWithValue("voiturier", entity.LogVoiturier);
                    command.Parameters.AddWithValue("roomService", entity.LogRoomService);
                    command.Parameters.AddWithValue("idLogement", entity.idTypeLogement);
                    command.Parameters.AddWithValue("idProprietaire", entity.idProprietaire);
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
                    command.CommandText = "DELETE FROM [Logement] WHERE [idLogement] = @id";
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        //PAS DE TEMPS
        public IEnumerable<Logement> GetByTypeLogement(int idTypeLogement)
        {
            throw new NotImplementedException();

            //using (SqlConnection connection = new SqlConnection(_connectionString))
            //{
            //    using (SqlCommand command = connection.CreateCommand())
            //    {
            //        command.CommandText = "SELECT [idLogement], [nom], [boite], [numero], [rue], [pays], [coordLatitude], [coordLongitude], [desciptionCourte], [descriptionLongue], [chambre], [piece], [capacite], [salledeBain], [wc], [balcon], [airConcitionne], [wifi], [minibar], [animaux], [piscine], [voiturier], [roomService], [idTypeLogement], [idProprietaire] FROM [Logement] WHERE [idTypeLogement] = @id";
            //        command.Parameters.AddWithValue("idTypeLogement", id);
            //        connection.Open();
            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            if (reader.Read()) return reader.ToLogement();
            //            return null;
            //        }
            //    }
            //}
        }
    }
}
