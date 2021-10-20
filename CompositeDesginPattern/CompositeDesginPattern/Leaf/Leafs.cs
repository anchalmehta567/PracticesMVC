using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeDesginPattern.Component;

namespace CompositeDesginPattern.Leaf
{
    public class Leafs : IComponent
    {
        public Leafs(int Price,string name)
        {
            price = Price;
            name = Name;
        }
        public int price { get; set; }
        public string Name { get; set; }
        public void ShowPrice()
        {
            Console.WriteLine(Name +"" + price);
        }
    }
}
