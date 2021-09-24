using System;
using Xunit;
using CreditCardApplication;

namespace CreditCardApllication.Tests
{
    public class CreditClassApplicationEvaluatorShould
    {
        [Fact]
        public void AcceptHighIncomeApplication()
        {
            var sut = new CreditClassApplicationEvaluator();
            var application = new CreditCardApplication { GrossAnnualIncome = 1000_000 };

        }
    }
}
