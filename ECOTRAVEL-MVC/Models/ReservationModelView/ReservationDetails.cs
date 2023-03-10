using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECOTRAVEL_MVC.Models.ReservationModelView
{
    public class ReservationDetails
    {
        [DisplayName("Identifiant")]
        [ScaffoldColumn(false)]
        public int idReservation { get; set; }
        [DisplayName("CheckIn:")]
        public DateTime ResCheckIn { get; set; }
        [DisplayName("CheckOut :")]
        public DateTime ResCheckOut { get; set; }
        [DisplayName("Nombre d'adulte :")]
        public int ResAdulte { get; set; }
        [DisplayName("Nombre d'enfant :")]
        public int ResEnfant { get; set; }
        [DisplayName("Besoin d'assurance :")]
        public bool ResAssusrance { get; set; }
        [DisplayName("Date d'Annulation (facultatif) :")]
        public DateTime ResDateAnnulation { get; set; }
        [DisplayName("Annulation du Propietaire (facultatif) :")]
        public bool ResAnnulationProprietaire { get; set; }
        [DisplayName("Date de reservation :")]
        public int idIndisponible { get; set; }
        [DisplayName("Logement reservé :")]
        public int idLogement { get; set; }
        [DisplayName("Reservation faite par :")]
        public int idClient { get; set; }
    }
}
