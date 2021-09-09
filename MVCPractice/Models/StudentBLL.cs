using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPractice.Models
{
    public class StudentBLL
    {
        public IStudentDe Istudent;
        public StudentBLL(IStudentDe Istudent)
        {
            this.Istudent = Istudent;
        }
        public List<StudentDe> AllStudent()
        {

            List<StudentDe> li = new List<StudentDe>();
            List<tbl_Student> students = Istudent.GetAllStudents();
            foreach (var item in students)
            {
                StudentDe s = new StudentDe();
                s.id = item.id;
                s.FirstName = item.FirstName;
                s.LastName = item.LastName;
                li.Add(s);

            }
            return li;
        }
    }
}