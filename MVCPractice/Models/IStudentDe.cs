using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCPractice.Models;

namespace MVCPractice.Models
{
   public  interface IStudentDe
    {
        List<tbl_Student> GetAllStudents();

    }
}
