using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCPractice.Models
{
    public class EmployeeModel
    {
        public int id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public int? AddressId { get; set; }
        [Required]
        public string Code { get; set; }
        public AddressModel Address { get; set; }

        
    }
}