using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompositeDesginPattern.Component;
using CompositeDesginPattern.Component;

namespace CompositeDesginPattern.Composite

{
    public class Composites : IComponent
    {

        public string Name { get; set; }
   public List<IComponent> components ;
        public Composites(string name) 
        { Name = name;
            components = new List<IComponent>(); 
        }
        public void ShowPrice()
        {
            Console.WriteLine(""+Name);
            foreach (var com in components) { com.ShowPrice(); }

        }
    }
}
