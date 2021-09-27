using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreditCardApplications
{
   public   class CreditClassApplicationEvaluator
    {
        private readonly IFrequentFlyerNumberValidator validator;
        private const int AutoRefferalMaxAge = 20;
        private const int HighIncomeThreshold = 100_000;
        private const int LowIncomeThreshold = 20_000;

        public int ValidatorlookupCount { get; private set; }
        public CreditClassApplicationEvaluator(IFrequentFlyerNumberValidator validator) 
        {
            this.validator = validator ?? throw new System.ArgumentNullException(nameof(validator));
        }
      public CreditCardApplicatonDecision Evalute(CreditCardApplication application)
        {
            if (application.GrossAnnualIncome >= HighIncomeThreshold)
            {
                return CreditCardApplicatonDecision.AutoAccepted;
            }

            //  var isValidFrequentlyFlyerNumber = validator.IsValid(application.FrequentFlyerNumber);

            bool isValidFrequentlyFlyerNumber;
            try
            {
                isValidFrequentlyFlyerNumber = validator.IsValid(application.FrequentFlyerNumber);

            }
            catch(Exception)
            {
                //log
                return CreditCardApplicatonDecision.ReferredToHuman;
            }
            if (!isValidFrequentlyFlyerNumber)
            {
                return CreditCardApplicatonDecision.ReferredToHuman;
            }

            if (validator.ServiceInformation.License.LicenseKey == "EXPIRED") 
            {
                return CreditCardApplicatonDecision.ReferredToHuman;
            }
            validator.Validationmode = application.Age >= 30 ? Validationmode.Detailed : Validationmode.Quick;

            if (application.Age <= AutoRefferalMaxAge)
            {
                return CreditCardApplicatonDecision.ReferredToHuman;
            }
            if (application.GrossAnnualIncome < LowIncomeThreshold)
            {
                return CreditCardApplicatonDecision.AutoDeclined;
            }
            return CreditCardApplicatonDecision.ReferredToHuman;

        }
        /*  public CreditCardApplicatonDecision EvaluteusingOut(CreditCardApplication application) 
      {
          if (application.GrossAnnualIncome >= HighIncomeThreshold) 
          {
              return CreditCardApplicatonDecision.AutoAccepted;
          }
          validator.IsValid(application.FrequentFlyerNumber, out var iValidFrequentlyFlyerNumber);

      //    var iValidrequentlyFlyerNumber = validator.IsValid(application.FrequentFlyerNumber);
          if (!iValidFrequentlyFlyerNumber) 
          {
              return CreditCardApplicatonDecision.ReferredToHuman;
          }


          if (application.Age <= AutoRefferalMaxAge)
          {
              return CreditCardApplicatonDecision.ReferredToHuman; 
          }
          if (application.GrossAnnualIncome <LowIncomeThreshold)
          {
              return CreditCardApplicatonDecision.AutoDeclined;
          }
      return CreditCardApplicatonDecision.ReferredToHuman;

      }
*/

    }
}
