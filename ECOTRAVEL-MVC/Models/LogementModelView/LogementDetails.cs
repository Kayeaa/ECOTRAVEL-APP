using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECOTRAVEL_MVC.Models.LogementModelView
{
    public class LogementDetails
    {
        [DisplayName("Identifiant")]
        [ScaffoldColumn(false)]
        public int idLogement { get; set; }
        [DisplayName("Nom du Logement :")]
        public string LogNom { get; set; }
        [DisplayName("Boite :")]
        public string LogBoite { get; set; }
        [DisplayName("Numero de rue :")]
        public string LogNum { get; set; }
        [DisplayName("Rue :")]
        public string LogRue { get; set; }
        [DisplayName("Pays :")]
        public string LogPays { get; set; }
        [DisplayName("Coordonnée geographique - Latitude :")]
        public decimal LogCoorLatitude { get; set; }
        [DisplayName("Coordonnée geographique- Longitude :")]
        public decimal LogCoorLongitude { get; set; }
        [DisplayName("Courte description :")]
        public string LogDescriptionCourte { get; set; }
        [DisplayName("Longue description :")]
        public string LogDescriptionLongue { get; set; }
        [DisplayName("Chambre(s) :")]
        public int LogChambre { get; set; }
        [DisplayName("Piece(s) :")]
        public int LogPiece { get; set; }
        [DisplayName("Capacité :")]
        public int LogCapacite { get; set; }
        [DisplayName("Salle de bain :")]
        public int LogSalledeBain { get; set; }
        [DisplayName("WC :")]
        public int LogWc { get; set; }
        [DisplayName("Balcon :")]
        public bool LogBalcon { get; set; }
        [DisplayName("Air Conditionnée :")]
        public bool LogAirConditionne { get; set; }
        [DisplayName("Wifi :")]
        public bool LogWifi { get; set; }
        [DisplayName("Minibar :")]
        public bool LogMinibar { get; set; }
        [DisplayName("Animaux admis :")]
        public bool LogAnimaux { get; set; }
        [DisplayName("Piscine :")]
        public bool LogPiscine { get; set; }
        [DisplayName("Voiturier disponible :")]
        public bool LogVoiturier { get; set; }
        [DisplayName("Service de chambre :")]
        public bool LogRoomService { get; set; }
        [DisplayName("Prix par nuit :")]
        public float LogPrix { get; set; }
        [DisplayName("Type de Logement :")]
        public int idTypeLogement { get; set; }
        [DisplayName("Proprietaire :")]
        public int idProprietaire { get; set; }
    }
}
