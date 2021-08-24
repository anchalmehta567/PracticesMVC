using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCPractice.Models
{
    public class DataEmployee
    {
        [Required(ErrorMessage ="Name is required")]
        [EmployeeeDataCustomValidation]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Range(18,100)]
        public int Age { get; set; }


    }
}