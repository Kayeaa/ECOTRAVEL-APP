using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECOTRAVEL_MVC.Models.ReservationModelView
{
    public class ReservationCreateForm
    {
        [Required]
        [DisplayName("CheckIn : ")]
        public DateTime ResCheckIn { get; set; }

        [Required]
        [DisplayName("CheckOut : ")]
        public DateTime ResCheckOut { get; set; }

        [Required]
        [MaxLength(4)]
        [MinLength(1)]
        [DisplayName("Adulte : ")]
        public int ResAdulte { get; set; }

        [Required]
        [MaxLength(3)]
        [MinLength(1)]
        [DisplayName("Enfant : ")]
        public int ResEnfant { get; set; }

    }
}
