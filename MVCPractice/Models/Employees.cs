using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPractice.Models
{
    public class Employees
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
    }
}