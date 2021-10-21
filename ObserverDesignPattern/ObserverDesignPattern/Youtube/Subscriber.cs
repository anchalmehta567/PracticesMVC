using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.Youtube;

namespace ObserverDesignPattern.Youtube
{
    public  class Subscriber
    {
        private string name;
        private Channel channel = new Channel();
        public Subscriber(string Name){ name = Name; }

        public void update() 
        {
            Console.WriteLine(" Hey  " + name +"  Video uploded");
        }
        public void subscribrchannel(Channel ch)
        {
            channel = ch;
        }


    }
}
