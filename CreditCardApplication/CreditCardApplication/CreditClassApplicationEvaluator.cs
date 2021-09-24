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
        public CreditClassApplicationEvaluator(IFrequentFlyerNumberValidator validator) 
        {
            this.validator = validator ??throw new System.ArgumentException(nameof(validator));


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
        public CreditCardApplicatonDecision Evalute(CreditCardApplication application)
        {
            if (application.GrossAnnualIncome >= HighIncomeThreshold)
            {
                return CreditCardApplicatonDecision.AutoAccepted;
            }
            var iValidrequentlyFlyerNumber = validator.IsValid(application.FrequentFlyerNumber);
            if (!iValidrequentlyFlyerNumber)
            {
                return CreditCardApplicatonDecision.ReferredToHuman;
            }
            if (validator.ServiceInformation.License.LicenseKey == "EXPIRED") 
            {
                return CreditCardApplicatonDecision.ReferredToHuman;
            }
            
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
    }
}
