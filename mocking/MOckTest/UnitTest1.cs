using System;
using Xunit;
using mocking;
using Moq;

namespace MOckTest
{
    public class UnitTest1
    {
        [Fact]
        public void Testcaseforimplementingmethod()
        {
            var mock = new Mock<repository>();
            Business business= new Business(mock.Object);
            Assert.Equal(4, business.Addition(2, 2));
        }
        [Fact]
        public void Testfornotimplementmethods() 
        {
            var mock = new Mock<repository>();
            mock.Setup(self => self.sub(3, 2)).Returns(3);
            Business business = new Business(mock.Object);
            Assert.Equal(3, business.Subtraction(3, 2));
        }
        [Fact]
        public void ADD_Empty_String_0() 
        {
            StringCakculator calc = new StringCakculator();
            int exceptResult = 0;
            int result = calc.Add("");
            Assert.Equal(exceptResult, result);
        }
        [Theory]
        [InlineData("12",12)]
        public void Add_SingleNumbers_ReturnsTheNumber(string input ,int exceptedResult) 
        {
            StringCakculator calc = new StringCakculator();
             int result = calc.Add(input);
            Assert.Equal(exceptedResult, result);



        }
    }
}
