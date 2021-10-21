using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ObserverDesignPattern.Youtube;
namespace ObserverDesignPattern.Youtube
{
public    class Channel
    {
       private  List<Subscriber> subs = new List<Subscriber>();
       public  string title;
        public void subscribe(Subscriber sub) 
        {
            subs.Add(sub);
        }

        public void Unsubscribe(Subscriber sub)
        {
            subs.Remove(sub);
        }
        public void NotifySubscribers()
        {

            foreach (var sub in subs) { sub.update(); }

        }
        public void upload(string title) { this.title = title; NotifySubscribers(); }

    }
}
