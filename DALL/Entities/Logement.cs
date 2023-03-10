using Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Logement : ILogement
    {
        public int idLogement { get; set; }
        public string LogNom { get; set; }
        public string LogBoite { get; set; }
        public string LogNum { get; set; }
        public string LogRue { get; set; }
        public string LogPays { get; set; }
        public decimal LogCoorLatitude { get; set; }
        public decimal LogCoorLongitude { get; set; }
        public string LogDescriptionCourte { get; set; }
        public string LogDescriptionLongue { get; set; }
        public int LogChambre { get; set; }
        public int LogPiece { get; set; }
        public int LogCapacite { get; set; }
        public int LogSalledeBain { get; set; }
        public int LogWc { get; set; }
        public bool LogBalcon { get; set; }
        public bool LogAirConditionne { get; set; }
        public bool LogWifi { get; set; }
        public bool LogMinibar { get; set; }
        public bool LogAnimaux { get; set; }
        public bool LogPiscine { get; set; }
        public bool LogVoiturier { get; set; }
        public bool LogRoomService { get; set; }
        public float LogPrix { get; set; }
        public int idTypeLogement { get; set; }
        public int idProprietaire { get; set; }
    }
}
