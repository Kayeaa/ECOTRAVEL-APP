using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECOTRAVEL_MVC.Models.ClientModelView
{
    public class ClientListItem
    {
        [DisplayName("Identifiant")]
        [ScaffoldColumn(false)]
        public int idClient { get; set; }

        [DisplayName("Nom")]
        public string CliNom { get; set; }

        [DisplayName("Prenom")]
        public string CliPrenom { get; set; }

        [DisplayName("Email")]
        public string CliEmail { get; set; }

        [DisplayName("Telephone")]
        public string CliTelephone { get; set; }

        [DisplayName("Pays")]
        public string CliPays { get; set; }

    }
}
