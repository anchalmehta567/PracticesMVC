using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singletone
    {
        private static int counter = 0;

        //private static readonly object obj = new object();
        //To achive lazy looger we follow three stpes 
        //change null intialization to singletone
        //private static Singletone instance = null;
        //change it to readonly property
        //remove the double locking change

        //        private static readonly Singletone instance = new Singletone();


        //lazy intialization
        private static readonly  Lazy<Singletone> instance = new Lazy<Singletone>(()=>new Singletone());


        public static Singletone GetInstance 
        { 
            get 
            {
                /* 
                 if (instance == null) 
                  {
                      lock (obj)
                      {
                          if (instance == null)
                              instance = new Singletone();      
                      }
                   }   
                
                */
                return instance.Value;
            }
        }
        private Singletone() 
        {
            counter++;
            Console.WriteLine("Counter value is "+counter.ToString());
        }
        public void PrintDetails(String message) 
        {
            Console.WriteLine(message);
        }
    
        //   public class DerivedSingletone : Singletone {}
     
    }
}
