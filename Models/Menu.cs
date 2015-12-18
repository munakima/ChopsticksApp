using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Menu
    {
        /// <summary>
        /// get the Menu Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// get the MenuTypeId
        /// </summary>
        [Display(Name = "MenuType")]
        public int MenuTypeId { get; set; }
        /// <summary>
        /// get the Food Id 
        /// </summary>
        [Display(Name = "Food")]
        public int FoodId { get; set; }
        public virtual Food food { get; set; }
        public virtual MenuType menuType { get; set; }
    }
}
