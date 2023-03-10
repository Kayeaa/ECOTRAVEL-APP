using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLLe = BLL.Entities;
using DALe = DAL.Entities;

namespace BLL.Mapper
{
    static class Mapper
    {
        public static  BLLe.Client ToBLL(this DALe.Client entity)
        {
            if (entity is null) return null;
            return new BLLe.Client()
            {
                idClient = entity.idClient,
                CliNom = entity.CliNom,
                CliPrenom = entity.CliPrenom,
                CliEmail = entity.CliEmail,
                CliPays = entity.CliPays,
                CliTelephone = entity.CliTelephone,
                CliPassword = entity.CliPassword
            };
        }


        public static DALe.Client ToDAL(this BLLe.Client entity)
        {
            if (entity is null) return null;
            return new DALe.Client()
            {
                idClient = entity.idClient,
                CliNom = entity.CliNom,
                CliPrenom = entity.CliPrenom,
                CliEmail = entity.CliEmail,
                CliPays = entity.CliPays,
                CliTelephone = entity.CliTelephone,
                CliPassword = entity.CliPassword
            };
        }

        public static BLLe.Logement ToBLL(this DALe.Logement entity)
        {
            if (entity is null) return null;
            return new BLLe.Logement()
            {
                idLogement = entity.idLogement,
                LogNom = entity.LogNom,
                LogBoite = entity.LogBoite,
                LogNum = entity.LogNum,
                LogPays = entity.LogPays,
                LogCoorLatitude = entity.LogCoorLatitude,
                LogCoorLongitude = entity.LogCoorLongitude,
                LogDescriptionCourte = entity.LogDescriptionCourte,
                LogDescriptionLongue = entity.LogDescriptionLongue,
                LogChambre = entity.LogChambre,
                LogPiece = entity.LogPiece,
                LogCapacite = entity.LogCapacite,
                LogSalledeBain = entity.LogSalledeBain,
                LogWc = entity.LogWc,
                LogBalcon = entity.LogBalcon,
                LogAirConditionne = entity.LogAirConditionne,
                LogWifi = entity.LogWifi,
                LogMinibar = entity.LogMinibar,
                LogAnimaux = entity.LogAnimaux,
                LogPiscine = entity.LogPiscine,
                LogVoiturier = entity.LogVoiturier,
                LogRoomService = entity.LogRoomService,
                LogPrix = entity.LogPrix,
                idTypeLogement = entity.idTypeLogement,
                idProprietaire = entity.idProprietaire
            };
        }


        public static DALe.Logement ToDAL(this BLLe.Logement entity)
        {
            if (entity is null) return null;
            return new DALe.Logement()
            {
                idLogement = entity.idLogement,
                LogNom = entity.LogNom,
                LogBoite = entity.LogBoite,
                LogNum = entity.LogNum,
                LogPays = entity.LogPays,
                LogCoorLatitude = entity.LogCoorLatitude,
                LogCoorLongitude = entity.LogCoorLongitude,
                LogDescriptionCourte = entity.LogDescriptionCourte,
                LogDescriptionLongue = entity.LogDescriptionLongue,
                LogChambre = entity.LogChambre,
                LogPiece = entity.LogPiece,
                LogCapacite = entity.LogCapacite,
                LogSalledeBain = entity.LogSalledeBain,
                LogWc = entity.LogWc,
                LogBalcon = entity.LogBalcon,
                LogAirConditionne = entity.LogAirConditionne,
                LogWifi = entity.LogWifi,
                LogMinibar = entity.LogMinibar,
                LogAnimaux = entity.LogAnimaux,
                LogPiscine = entity.LogPiscine,
                LogVoiturier = entity.LogVoiturier,
                LogRoomService = entity.LogRoomService,
                LogPrix = entity.LogPrix,
                idTypeLogement = entity.idTypeLogement,
                idProprietaire = entity.idProprietaire

            };
        }

        public static BLLe.Reservation ToBLL(this DALe.Reservation entity)
        {
            if (entity is null) return null;
            return new BLLe.Reservation()
            {
                idReservation = entity.idReservation,
                ResCheckIn = entity.ResCheckIn,
                ResCheckOut = entity.ResCheckOut,
                ResAdulte = entity.ResAdulte,
                ResEnfant = entity.ResEnfant,
                ResAssurance = entity.ResAssurance,
                ResDateAnnulation = entity.ResDateAnnulation,
                ResAnnulationProprietaire = entity.ResAnnulationProprietaire,
                idIndisponible = entity.idIndisponible,
                idLogement=entity.idLogement,
                idClient=entity.idClient
            };
        }


        public static DALe.Reservation ToDAL(this BLLe.Reservation entity)
        {
            if (entity is null) return null;
            return new DALe.Reservation()
            {
                idReservation = entity.idReservation,
                ResCheckIn = entity.ResCheckIn,
                ResCheckOut = entity.ResCheckOut,
                ResAdulte = entity.ResAdulte,
                ResEnfant = entity.ResEnfant,
                ResAssurance = entity.ResAssurance,
                ResDateAnnulation = entity.ResDateAnnulation,
                ResAnnulationProprietaire = entity.ResAnnulationProprietaire,
                idIndisponible = entity.idIndisponible,
                idLogement = entity.idLogement,
                idClient = entity.idClient
            };
        }

    }
}
