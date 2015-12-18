using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
  public  class MenuType
    {
        /// <summary>
        /// get the MenuType Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// get the MenuType Name
        /// </summary>
        [Display(Name = "Name")]
        public string Name { get; set; }


       
    }
}
