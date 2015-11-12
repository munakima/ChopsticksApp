using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class HomepicDetails
    {
        /// <summary>
        /// get the Homepic Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// get the Homepic Url
        /// </summary>
        [Display(Name = "Url")]
        public string Url { get; set; }
    }
}
