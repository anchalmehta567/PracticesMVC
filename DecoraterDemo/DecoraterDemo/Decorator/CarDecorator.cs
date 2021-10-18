using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoraterDemo.Component;
namespace DecoraterDemo.Decorator
{
    public abstract class CarDecorator : ICar
    {
        private ICar car;
        public CarDecorator(ICar _car) { this.car = _car; }
        public virtual  string Make { get { return car.Make; } }

        public  virtual double GetPrice()
        {
            return car.GetPrice();
        }
        public abstract double GetDiscountpric(); 
     
    }
}
