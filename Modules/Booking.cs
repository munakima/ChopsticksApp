//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Booking
    {
        public int Id { get; set; }

        public string CustName { get; set; }

        public string CustPhoneNum { get; set; }

        public int CustPersonNum { get; set; }

        public Nullable<int> CustBabyNum { get; set; }
        public System.DateTime Nowday { get; set; }
        public System.DateTime BookingTime { get; set; }
        public string TableNum { get; set; }
    }
}
