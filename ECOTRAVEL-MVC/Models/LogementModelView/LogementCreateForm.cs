using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECOTRAVEL_MVC.Models.LogementModelView
{
    public class LogementCreateForm
    {

        [Required]
        [MaxLength(255)]
        [MinLength(1)]
        [DisplayName("Nom : ")]
        public string LogNom { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Boite : ")]
        public string LogBoite { get; set; }

        [Required]
        [MaxLength(5)]
        [MinLength(1)]
        [EmailAddress]
        [DisplayName("Numero : ")]
        public string LogNum { get; set; }

        [Required]
        [MaxLength(250)]
        [MinLength(1)]
        [DisplayName("Rue : ")]
        public string LogRue { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(4)]
        [DisplayName("Pays : ")]
        public string LogPays { get; set; }

        [Required]
        [MaxLength(8)]
        [MinLength(1)]
        [DisplayName("Coordonné- Latitude : ")]
        public decimal LogCoorLatitude { get; set; }

        [Required]
        [MaxLength(250)]
        [MinLength(1)]
        [DisplayName("Coordonné- Latitude : ")]
        public decimal LogCoorLongitude { get; set; }

        [Required]
        [MaxLength(140)]
        [MinLength(4)]
        [DisplayName("Description courte : ")]
        public string LogDescriptionCourte { get; set; }

        [Required]
        [MinLength(4)]
        [DisplayName("Description longue : ")]
        public string LogDescriptionLongue { get; set; }

        [Required]
        [MaxLength(4)]
        [MinLength(1)]
        [DisplayName("Nombre de chambre : ")]
        public int LogChambre { get; set; }


        [Required]
        [MaxLength(4)]
        [MinLength(1)]
        [DisplayName("Nombre de piece : ")]
        public int LogPiece { get; set; }

        [Required]
        [MaxLength(4)]
        [MinLength(1)]
        [DisplayName("Capacité : ")]
        public int LogCapacite { get; set; }

        [Required]
        [MaxLength(4)]
        [MinLength(1)]
        [DisplayName("SalledeBain : ")]
        public int LogSalledeBain { get; set; }

        [Required]
        [MaxLength(4)]
        [MinLength(1)]
        [DisplayName("Nombre de toilette : ")]
        public int LogWc { get; set; }

        [Required]
        [DisplayName("Balcon : ")]
        public bool LogBalcon { get; set; }

        [Required]
        [DisplayName("Air conditionné : ")]
        public bool LogAirConditionne { get; set; }

        [Required]
        [DisplayName("Wifi : ")]
        public bool LogWifi { get; set; }

        [Required]
        [DisplayName("Minibar : ")]
        public bool LogMinibar { get; set; }


        [Required]
        [DisplayName("Animaux admis : ")]
        public bool LogAnimaux { get; set; }

        [Required]
        [DisplayName("Piscine : ")]
        public bool LogPiscine { get; set; }

        [Required]
        [DisplayName("Voiturier : ")]
        public bool LogVoiturier { get; set; }

        [Required]
        [MaxLength(4)]
        [MinLength(1)]
        [DisplayName("Service de chambre : ")]
        public bool LogRoomService { get; set; }

        [Required]
        [MaxLength(4)]
        [MinLength(1)]
        [DisplayName("Prix par nuit : ")]
        public float LogPrix { get; set; }

        [Required]
        [MinLength(1)]
        [DisplayName("Type de logement : ")]
        public int idTypeLogement { get; set; }

        [Required]
        [MinLength(1)]
        [DisplayName("Proprietaire : ")]
        public int idProprietaire { get; set; }
    }
}
