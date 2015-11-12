using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ChopApp.Models
{
    public class Homepic
    {

        [Display(Name ="Id")]
        public int Id { get; set; }
        [Display(Name = "Url")]
        public string Url { get; set; }
    }
}