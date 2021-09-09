using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCPractice.Models;

namespace MVCPractice.Models
{
    public class StudentDAL : IStudentDe
    {
        BookDBEntities db = new BookDBEntities();
        public List<tbl_Student> GetAllStudents()
        {
            return db.tbl_Student.ToList();
        }

    }
    
}