using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyExample.Models
{
  public   interface IStudent
    {
        List<tblStudent> GetAllStudents();

    }
}
