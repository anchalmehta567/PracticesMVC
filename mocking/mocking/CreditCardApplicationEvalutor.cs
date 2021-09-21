using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mocking
{
public    class CreditCardApplicationEvalutor
    {
        private const int AutoRefreMaxAge = 20;
        private const int HighIncomeThreshold = 100_000;
        private const int LowIncomeThreshold = 20_000;
        public CreditCardApplicationDeciion  Evaluate(CreditCardApplication application)
        {
            if (application.GrossAnimalIncome >= HighIncomeThreshold) 
            {
                return CreditCardApplicationDeciion.AutoAccepted;
            }
            if (application.Age <= AutoRefreMaxAge) 
            
          {
                return CreditCardApplicationDeciion.referredToHuman;
            }
            if (application.GrossAnimalIncome < LowIncomeThreshold) { return CreditCardApplicationDeciion.AutoDeclined; }
            return CreditCardApplicationDeciion.referredToHuman;
        }
    }
}
