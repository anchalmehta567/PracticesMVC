using System;
using ObserverDesignPattern.Amazon;
using ObserverDesignPattern.Youtube;
namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel telusko = new Channel();
            Subscriber s1 = new Subscriber("Anchal");
            Subscriber s2 = new Subscriber("Anjali");
            Subscriber s3 = new Subscriber("Akshay");
            Subscriber s4 = new Subscriber("Harsh");
            Subscriber s5 = new Subscriber("Sonam");
            telusko.subscribe(s1);
            s1.subscribrchannel(telusko);
            telusko.upload("Real life example of desgin Pattern");

            ////



            //Create a Product with Out Of Stock Status
            Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
            //User Anurag will be created and user1 object will be registered to the subject
            Observer user1 = new Observer("Anurag", RedMI);
            //User Pranaya will be created and user1 object will be registered to the subject
            Observer user2 = new Observer("Pranaya", RedMI);
            //User Priyanka will be created and user3 object will be registered to the subject
            Observer user3 = new Observer("Priyanka", RedMI);

            Console.WriteLine("Red MI Mobile current state : " + RedMI.getAvailability());
            Console.WriteLine();
            // Now product is available
            RedMI.setAvailability("Available");
            Console.Read();



        }
    }
}
