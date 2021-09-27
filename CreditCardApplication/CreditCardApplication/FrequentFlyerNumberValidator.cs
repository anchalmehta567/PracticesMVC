using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardApplications
{
    public class FrequentFlyerNumberValidator : IFrequentFlyerNumberValidator
    {
        public IserviceInformation ServiceInformation => throw new NotImplementedException();

/*public string LicenseKey
{
get
{
throw new NotImplementedException();
}
}*/


        public bool IsValid(string frequentFlyerNumber)
        {
            throw new NotImplementedException("The problem is arise here  this real dependency begin hard to use");
        }

        public void IsValid(string frequentFlyerNumber, out bool isvalid)
        {
            throw new NotImplementedException("Simulate this real dependency begin hard to use");
        }
        
        public Validationmode Validationmode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
