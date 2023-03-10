using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Avis : IAvis
    {
        public int idAvis { get; set; }
        public int AvisNotes { get; set; }
        public int idLogement { get; set; }
        public int idClient { get; set; }
        public string AvisMessage { get; set; }
    }
}
