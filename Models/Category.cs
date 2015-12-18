using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Category
    {
        /// <summary>
        /// get the Category Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// get the Category Url
        /// </summary>
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
