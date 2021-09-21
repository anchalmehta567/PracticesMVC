using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mocking;
using Xunit;
using Moq;
namespace MOckTest
{
  public  class creditemock
    {
        [Fact]
        public void AcceptedHighncome() 
        {
            var sut = new CreditCardApplicationEvalutor();
            var application = new CreditCardApplication { GrossAnimalIncome = 100_100 };
            CreditCardApplicationDeciion deciion = sut.Evaluate(application);
            Assert.Equal(CreditCardApplicationDeciion.AutoAccepted,deciion);
        }
    }
}
