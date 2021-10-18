using System;
using DecoraterDemo.Component;
using DecoraterDemo.ConcreateDecorator;
using DecoraterDemo.ConcreteComponent;
using DecoraterDemo.Decorator;
namespace DecoraterDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            ICar car = new Suzuki();
            CarDecorator decorator = new OfficePrice(car);
            Console.WriteLine(string.Format("make :{0} Pric :{1}" +"DicountPrice:{2}", decorator.Make,decorator.GetPrice().ToString(),decorator.GetDiscountpric().ToString()));
            Console.ReadLine();

        }
    }
}
