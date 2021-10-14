using System;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*    Singletone s1 = new Singletone();
               s1.PrintDetails("This is firstMessgae");
            */
            Parallel.Invoke(

                () => PrintStudentDetails(),
                () =>PrintEmployeeDetails()
                );
            /*PrintStudentDetails();

            PrintEmployeeDetails();
*/


            //  Singletone.DerivedSingletone deriveobj = new Singletone.DerivedSingletone();
            // deriveobj.PrintDetails("From Derived Class");
            Console.ReadLine();

        }

        private static void PrintEmployeeDetails()
        {
            Singletone fromStudent = Singletone.GetInstance; 
            fromStudent.PrintDetails("From Student");
        }

        private static void PrintStudentDetails()
        {
            Singletone fromemployee = Singletone.GetInstance;
            fromemployee.PrintDetails("From Employee");
        }
    }
}
