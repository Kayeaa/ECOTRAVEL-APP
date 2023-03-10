using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Reservation : IReservation
    {
        public int idReservation { get; set; }
        public DateTime ResCheckIn { get; set; }
        public DateTime ResCheckOut { get; set; }
        public int ResAdulte { get; set; }
        public int ResEnfant { get; set; }
        public bool ResAssurance { get; set; }
        public DateTime ResDateAnnulation { get; set; }
        public bool ResAnnulationProprietaire { get; set; }
        public int idIndisponible { get; set; }
        public int idLogement { get; set; }
        public int idClient { get; set; }
    }
}
