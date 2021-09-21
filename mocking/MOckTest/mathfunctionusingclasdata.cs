using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mocking;
using Xunit;

namespace MOckTest
{
    public  class mathfunctionusingclasdata
    {
        [Theory]
   [ClassData(typeof(calculatortestdata))]
   
        public void testAdd_GivenPotiveInputs_Shoulddifferent(int firstnumber, int secondnumber, int exceptedresult)
        {
            //arrange

            //Act
            var calculator = new Calculator();
            int result = calculator.add(firstnumber, secondnumber);
            //assert
            Assert.Equal(exceptedresult, result);

        }
    }
}
