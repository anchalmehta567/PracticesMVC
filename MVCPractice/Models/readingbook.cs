//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCPractice.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    
    public partial class readingbook
    {
        public int id { get; set; }
       // [AllowHtml]
        public string Title { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string location { get; set; }
        public string start_time { get; set; }
        public bool type { get; set; }
        public Nullable<int> d_hours { get; set; }
        public string description { get; set; }
        public string other_details { get; set; }
        public string iby_email { get; set; }
    }
}
