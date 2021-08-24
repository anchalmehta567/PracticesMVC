using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCPractice
{
    public class EmployeeeDataCustomValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null) 
            { 
                string Valueinput = value.ToString();
                if (string.IsNullOrEmpty(Valueinput)) 
                {
                    return ValidationResult.Success;
                }
                if (Valueinput.Contains("Anchal")) 
                {
                    return ValidationResult.Success;
                }
             
            }
            return new ValidationResult("String Should Contains Ancahl");
        }
    }
}