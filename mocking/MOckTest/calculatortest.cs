using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mocking;
using Xunit;
using Xunit.Abstractions;

namespace MOckTest
{
 public   class calculatortest
    {
        private readonly ITestOutputHelper _output;
        public calculatortest(ITestOutputHelper output) 
        {
            _output = output;
        }
        [Fact]
        [Trait("Categorey","Enemy")]
        public void TestAdd_GivenPositiveinput_shouldreturnSum() 
        {
            //arrange
            int firstnumber = 15;
            int secondnumber = 30;
            //Act
            var calculator = new Calculator();
            int result = calculator.add(firstnumber,secondnumber);
            //assert
            Assert.Equal(45, result);
            
        }
        [Fact(Skip ="Not run in the test")]
        
        public void TestAdd_GivenPositiveinput_shouldreturn()
        {
          
            //arrange
            int firstnumber = 10;
            int secondnumber = 30;
            //Act
            var calculator = new Calculator();
            int result = calculator.add(firstnumber, secondnumber);
            //assert
            Assert.Equal(40, result);

        }
        [Theory]
        [InlineData(15,30,45)]
        [InlineData(15, -30, -15)]
        [InlineData(-15, 30, 15)]
        [InlineData(-15, -30, -45)]

        public void testAdd_GivenPotiveInputs_Shoulddifferent(int firstnumber,int secondnumber,int exceptedresult)
        {
            _output.WriteLine("This is indie the theory concept");
            //arrange

            //Act
            var calculator = new Calculator();
            int result = calculator.add(firstnumber, secondnumber);
            //assert
            Assert.Equal(exceptedresult, result);

        }

        
    }
}
