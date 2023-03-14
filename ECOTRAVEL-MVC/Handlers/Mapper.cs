using BLL.Entities;
using ECOTRAVEL_MVC.Models.ClientModelView;
using ECOTRAVEL_MVC.Models.LogementModelView;
using ECOTRAVEL_MVC.Models.ReservationModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOTRAVEL_MVC.Handlers
{
    public static class Mapper
    {
        public static ClientListItem ToListItem(this Client entity)
        {
            //CLIENT
            if (entity is null) return null;
            return new ClientListItem()
            {
                idClient = entity.idClient,
                CliNom = entity.CliNom,
                CliPrenom = entity.CliPrenom,
                CliEmail = entity.CliEmail,
                CliPays = entity.CliPays,
                CliTelephone= entity.CliTelephone
            };
        }

        public static Client ToBLL(this ClientCreateForm entity)
        {
            if (entity is null) return null;
            return new Client()
            {
                CliNom = entity.CliNom,
                CliPrenom = entity.CliPrenom,
                CliEmail = entity.CliEmail,
                CliPays = entity.CliPays,
                CliTelephone = entity.CliTelephone,
                CliPassword = entity.CliPassword

            };
        }

        public static ClientDetails ToDetails(this Client entity)
        {
            if (entity is null) return null;
            return new ClientDetails()
            {
                CliNom = entity.CliNom,
                CliPrenom = entity.CliPrenom,
                CliEmail = entity.CliEmail,
                CliPays = entity.CliPays,
                CliTelephone = entity.CliTelephone
            };
        }

        //LOGEMENT
        public static LogementListItem ToListItem(this Logement entity)
        {
            if (entity is null) return null;
            return new LogementListItem()
            {
                idLogement = entity.idLogement,
                LogNom = entity.LogNom,
                LogBoite = entity.LogBoite,
                LogNum = entity.LogNum,
                LogRue = entity.LogRue,
                LogPays = entity.LogPays,
                LogCoorLatitude = entity.LogCoorLatitude,
                LogCoorLongitude = entity.LogCoorLongitude,
                LogDescriptionCourte = entity.LogDescriptionCourte,
                LogDescriptionLongue = entity.LogDescriptionCourte,
                LogChambre = entity.LogChambre,
                LogPiece = entity.LogPiece,
                LogCapacite = entity.LogCapacite,
                LogSalledeBain = entity.LogSalledeBain,
                LogWc = entity.LogWc,
                LogBalcon = entity.LogBalcon,
                LogAirConditionne = entity.LogAirConditionne,
                LogWifi = entity.LogWifi,
                LogMinibar = entity.LogMinibar,
                LogPiscine = entity.LogPiscine,
                LogVoiturier = entity.LogVoiturier,
                LogRoomService = entity.LogRoomService,
                LogPrix = entity.LogPrix,
                idTypeLogement = entity.idTypeLogement,
                idProprietaire = entity.idProprietaire
            };
        }

        public static Logement ToBLL(this LogementCreateForm entity)
        {
            if (entity is null) return null;
            return new Logement()
            {
                LogNom = entity.LogNom,
                LogBoite = entity.LogBoite,
                LogNum = entity.LogNum,
                LogRue = entity.LogRue,
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
                LogPiscine = entity.LogPiscine,
                LogVoiturier = entity.LogVoiturier,
                LogRoomService = entity.LogRoomService,
                LogPrix = entity.LogPrix,
                idTypeLogement = entity.idTypeLogement,
                idProprietaire = entity.idProprietaire

            };
        }

        public static LogementDetails ToDetails(this Logement entity)
        {
            if (entity is null) return null;
            return new LogementDetails()
            {
                LogNom = entity.LogNom,
                LogBoite = entity.LogBoite,
                LogNum = entity.LogNum,
                LogRue = entity.LogRue,
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
                LogPiscine = entity.LogPiscine,
                LogVoiturier = entity.LogVoiturier,
                LogRoomService = entity.LogRoomService,
                LogPrix = entity.LogPrix,
                idTypeLogement = entity.idTypeLogement,
                idProprietaire = entity.idProprietaire
            };
        }
        //RESERVATION
        public static ReservationListItem ToListItem(this Reservation entity)
        {
            if (entity is null) return null;
            return new ReservationListItem()
            {
                idReservation = entity.idReservation,
                ResCheckIn = entity.ResCheckIn,
                ResCheckOut = entity.ResCheckOut,
                ResAdulte = entity.ResAdulte,
                ResEnfant = entity.ResEnfant,
                ResAssusrance = entity.ResAssurance,
                ResDateAnnulation = entity.ResDateAnnulation,
                ResAnnulationProprietaire = entity.ResAnnulationProprietaire,
                idIndisponible = entity.idIndisponible,
                idLogement = entity.idLogement,
                idClient=entity.idClient
            
            };
        }

        public static Reservation ToBLL(this ReservationCreateForm entity)
        {
            if (entity is null) return null;
            return new Reservation()
            {
                ResCheckIn = entity.ResCheckIn,
                ResCheckOut = entity.ResCheckOut,
                ResAdulte = entity.ResAdulte,
                ResEnfant = entity.ResEnfant
            };
        }

        public static ReservationDetails ToDetails(this Reservation entity)
        {
            if (entity is null) return null;
            return new ReservationDetails()
            {
                ResCheckIn = entity.ResCheckIn,
                ResCheckOut = entity.ResCheckOut,
                ResAdulte = entity.ResAdulte,
                ResEnfant = entity.ResEnfant
            };
        }
    }
}
