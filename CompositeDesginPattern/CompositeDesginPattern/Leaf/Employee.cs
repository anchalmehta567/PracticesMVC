using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeDesginPattern.Component;
namespace CompositeDesginPattern.Leaf
{
    public class Employee : IEmployee
    {
        public Employee(string name,string dept) 
        {
            this.Name = name;
            this.Department=dept;
        }
        public string Name { get; set; }
        public string Department { get; set; }
        public void GetDetails()
        {
           
        Console.WriteLine(string.Format("Name :{0}, Dept :{1}", this.Name.ToString(),this.Department));
        }
    }
}
