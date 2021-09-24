using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCardApplications;

namespace CreditCardApplications
{
    public interface IlicenseData { string LicenseKey { get; } }
    public interface IserviceInformation { IlicenseData License { get; } }
    public  interface IFrequentFlyerNumberValidator
    {
        bool IsValid(string frequentFlyerNumber);
        void IsValid(string frequentFlyerNumber, out bool isvalid);
      //  string LicenseKey { get;  }
      IserviceInformation ServiceInformation { get; }
    }

    Validationmode ValidationMode { get; set; }
  }
