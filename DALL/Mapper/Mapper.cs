using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Mapper
{
    static class Mapper
    {
        public static Client ToClient(this IDataRecord record)
        {
            if (record is null) return null;
            return new Client()
            {
                idClient = (int)record[nameof(Client.idClient)],
                CliNom = (string)record[nameof(Client.CliNom)],
                CliPrenom = (string)record[nameof(Client.CliPrenom)],
                CliEmail = (string)record[nameof(Client.CliEmail)],
                CliPays = (string)record[nameof(Client.CliPays)],
                CliTelephone = (string)record[nameof(Client.CliTelephone)],
                CliPassword = "********"
            };
        }

        public static Logement ToLogement(this IDataRecord record)
        {
            if (record is null) return null;
            return new Logement()
            {
                idLogement = (int)record[nameof(Logement.idLogement)],
                LogNom = (string)record[nameof(Logement.LogNom)],
                LogBoite = (string)record[nameof(Logement.LogBoite)],
                LogNum = (string)record[nameof(Logement.LogNum)],
                LogRue = (string)record[nameof(Logement.LogRue)],
                LogPays = (string)record[nameof(Logement.LogPays)],
                LogCoorLatitude = (decimal)record[nameof(Logement.LogCoorLatitude)],
                LogCoorLongitude = (decimal)record[nameof(Logement.LogCoorLongitude)],
                LogDescriptionCourte = (string)record[nameof(Logement.LogDescriptionCourte)],
                LogDescriptionLongue = (string)record[nameof(Logement.LogDescriptionCourte)],
                LogChambre = (int)record[nameof(Logement.LogChambre)],
                LogPiece = (int)record[nameof(Logement.LogPiece)],
                LogCapacite = (int)record[nameof(Logement.LogCapacite)],
                LogSalledeBain = (int)record[nameof(Logement.LogSalledeBain)],
                LogWc = (int)record[nameof(Logement.LogWc)],
                LogBalcon = (bool)record[nameof(Logement.LogBalcon)],
                LogAirConditionne = (bool)record[nameof(Logement.LogAirConditionne)],
                LogWifi = (bool)record[nameof(Logement.LogWifi)],
                LogMinibar = (bool)record[nameof(Logement.LogMinibar)],
                LogPiscine = (bool)record[nameof(Logement.LogPiscine)],
                LogVoiturier = (bool)record[nameof(Logement.LogVoiturier)],
                LogRoomService = (bool)record[nameof(Logement.LogRoomService)],
                LogPrix = (int)record[nameof(Logement.LogPrix)],
                idTypeLogement = (int)record[nameof(Logement.idTypeLogement)],
                idProprietaire = (int)record[nameof(Logement.idProprietaire)]

            };
        }

        public static Avis ToAvis(this IDataRecord record)
        {
            if (record is null) return null;
            return new Avis()
            {
                idAvis = (int)record[nameof(Avis.idAvis)],
                AvisNotes = (int)record[nameof(Avis.AvisNotes)],
                idClient = (int)record[nameof(Avis.idClient)],
                idLogement = (int)record[nameof(Avis.idLogement)],
                AvisMessage = (string)record[nameof(Avis.AvisMessage)],
            };
        }

        public static Reservation ToReservation(this IDataRecord record)
        {
            if (record is null) return null;
            return new Reservation()
            {
                idReservation = (int)record[nameof(Reservation.idReservation)],
                ResCheckIn = (DateTime)record[nameof(Reservation.ResCheckIn)],
                ResCheckOut = (DateTime)record[nameof(Reservation.ResCheckOut)],
                ResAdulte = (int)record[nameof(Reservation.ResAdulte)],
                ResEnfant = (int)record[nameof(Reservation.ResEnfant)],
                ResAssurance = (bool)record[nameof(Reservation.ResAssurance)],
                ResDateAnnulation = (DateTime)record[nameof(Reservation.ResDateAnnulation)],
                ResAnnulationProprietaire = (bool)record[nameof(Reservation.ResAnnulationProprietaire)],
                idLogement = (int)record[nameof(Reservation.idLogement)],
                idClient = (int)record[nameof(Reservation.idClient)]
            };
        }
    }
}
