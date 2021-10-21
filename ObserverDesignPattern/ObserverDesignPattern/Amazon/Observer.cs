using ObserverDesignPattern.Amazone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Amazon
{
    public class Observer : IObserver
    {
        public string UserName { get; set; }
        public Observer(string userName, ISubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }

        public void update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
        }
    }
}
