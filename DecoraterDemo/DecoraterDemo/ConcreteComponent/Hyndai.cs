﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoraterDemo.Component;
namespace DecoraterDemo.ConcreteComponent
{
    public sealed class Hyndai : ICar
    {
        public string Make { get { return "HatchBack"; } }
        public double GetPrice()
        {
            return 800000;
        }
    }
}