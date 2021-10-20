using System;
using CompositeDesginPattern.Component;
using CompositeDesginPattern.Composite;
using CompositeDesginPattern.Leaf;
namespace CompositeDesginPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee John = new Employee("John","IT");
            IEmployee Mike = new Employee("Mike", "IT");
            IEmployee Jason = new Employee("Jason", "HR");
            IEmployee Eric = new Employee("Eric", "HR");
            IEmployee Henry = new Employee("Henry", "HR");

            IEmployee James = new Manager("james", "IT") { Subordinates = { John, Mike } };
         //   James.GetDetails();
            IEmployee Philip = new Manager("Philip", "HR") { Subordinates = { Jason, Eric } };

           // Philip.GetDetails();
            IEmployee Bob = new Manager("BoB", "Head") { Subordinates = { James, Philip } };

            Bob.GetDetails();
            Console.ReadLine();
        }
    }
}
