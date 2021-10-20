using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeDesginPattern.Component;

namespace CompositeDesginPattern.Composite
{
    public class Manager : IEmployee
    {
        public List<IEmployee> Subordinates;
        public Manager(string name, string dept)
        {
            this.Name = name;
            this.Department = dept;
            Subordinates = new List<IEmployee>();
        }
        public string Name { get; set; }
        public string Department { get; set; }
        public void GetDetails()
        {

            Console.WriteLine(string.Format("Name :{0}, Dept :{1}",
                this.Name.ToString(), this.Department));
            foreach (var employee in Subordinates) { employee.GetDetails(); }
        }
    }
}
