using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Food
    {
        /// <summary>
        /// get the Food Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// get the CategoryId
        /// </summary>

        public int CategaryId { get; set; }
        /// <summary>
        /// get the Food Name
        /// </summary>
        [Display(Name = "Food Name")]
        public string Name { get; set; }
        /// <summary>
        /// get the Food Price
        /// </summary>
        [Display(Name = "Food Price")]
        public int Price { get; set; }
        /// <summary>
        /// get the Food Detail
        /// </summary>
        [Display(Name = "Food Detail")]
        public string Detail { get; set; }
        public virtual Category Category { get; set; }
    }
}
