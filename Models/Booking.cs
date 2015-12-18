using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Booking
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string CustName { get; set; }
        [Required]
        [Display(Name = "Phone number")]
        public string CustPhoneNum { get; set; }
        [Required]
        [Display(Name = "Person(Adult)")]
        public int CustPersonNum { get; set; }
        [Display(Name = "Baby number")]
        public Nullable<int> CustBabyNum { get; set; }
        public System.DateTime Nowday { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "DateTime")]
        public System.DateTime BookingTime { get; set; }
        public string TableNum { get; set; }
    }
}
