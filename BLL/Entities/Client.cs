using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Client : IClient
    {
        private string _telephone;
        public int idClient { get; set; }
        public string CliNom { get; set; }
        public string CliPrenom { get; set; }
        public string CliEmail { get; set; }
        public string CliPays { get; set; }
        public string CliTelephone
        {
            get
            {
                return _telephone;
            }
            set
            {
                _telephone = value.Trim();
            }
        }
        public string CliPassword { get; set; }
    }

}
