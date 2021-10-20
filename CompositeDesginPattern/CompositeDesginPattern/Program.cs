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
            Console.WriteLine("Example 2 ");
         
// Example 2
            IComponent hd = new Leafs(4000, "HardDrive");
            IComponent mouse = new Leafs(3000,"Mouse");
            IComponent monitor = new Leafs(5000, "Monitor");
            IComponent Cabinet = new Composites("Abc") { components = { hd } };

            Cabinet.ShowPrice();
            Console.ReadLine();



        }
    }
}
