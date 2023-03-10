using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECOTRAVEL_MVC.Models.ClientModelView
{
    public class ClientCreateForm
    {
        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Nom de famille : ")]
        public string CliNom { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Prénom : ")]
        public string CliPrenom { get; set; }

        [Required]
        [MaxLength(255)]
        [MinLength(5)]
        [EmailAddress]
        [DisplayName("Adresse e-mail : ")]
        public string CliEmail { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Pays : ")]
        public string CliPays { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(4)]
        [DisplayName("Telephone : ")]
        public string CliTelephone { get; set; }

        [Required]
        [MaxLength(32)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [DisplayName("Mot de passe : ")]
        public string CliPassword { get; set; }

        [Required]
        [MaxLength(32)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Compare(nameof(CliPassword))]
        [DisplayName("Confirmez le mot de passe : ")]
        public string confirmPass { get; set; }
    }
}
