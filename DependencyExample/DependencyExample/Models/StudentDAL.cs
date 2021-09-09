using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DependencyExample.Models;

namespace DependencyExample.Models
{
    public class StudentDAL:IStudent
    {
        employeeDbEntities db = new employeeDbEntities();
        public List<tblStudent> GetAllStudents()
        {
            return db.tblStudents.ToList();
        }
       
    }
}