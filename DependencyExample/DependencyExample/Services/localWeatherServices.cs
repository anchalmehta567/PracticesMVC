using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyExample.Services
{
    public class localWeatherServices:IlocalWeatherServices
    {
      public   string GetLocalWetherByZipCode(string zipcode) 
        {
            return "It s snowing right know";

        }
    }
}