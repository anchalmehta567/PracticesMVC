using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoraterDemo.Decorator;
using DecoraterDemo.Component;
namespace DecoraterDemo.ConcreateDecorator
{
    public class OfficePrice : CarDecorator
    {
        public OfficePrice(ICar car):base(car) { }
        public override double GetDiscountpric()
        {
            return .8 * base.GetPrice();
        }
    }
}
