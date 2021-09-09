using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyExample.Services
{
    public  interface IlocalWeatherServices
    {
        string GetLocalWetherByZipCode(string zipcode);

    }
}
