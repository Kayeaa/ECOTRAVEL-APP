using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Client : IClient
    {
        public int idClient { get; set; }
        public string CliNom { get; set; }
        public string CliPrenom { get; set; }
        public string CliEmail { get; set; }
        public string CliPays { get; set; }
        public string CliTelephone { get; set; }
        public string CliPassword { get; set; }
    }
}
