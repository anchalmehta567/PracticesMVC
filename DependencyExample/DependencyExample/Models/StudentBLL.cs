using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DependencyExample.Models;

namespace DependencyExample.Models
{
    public class StudentBLL
    {
        public IStudent Istudent;
        public StudentBLL(IStudent Istudent)
        {
           this.Istudent = Istudent;
        }
        public List<Student> AllStudent()
        { 
            
            List<Student> li = new List<Student>();
            List<tblStudent> students = Istudent.GetAllStudents();
            foreach (var item in students) 
            {
                Student s = new Student();
                s.id = item.id;
                s.Name = item.Name;
                s.TotalMarks = (int)item.TotalMarks;
                li.Add(s);

            }
            return li;
        }


    }
}