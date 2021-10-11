using Xunit;
using Moq;
using System.Collections.Generic;
using System;

namespace CreditCardApplicationTest
{
  public   class Theory
    {
        public bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }

        [Theory]
        [InlineData(5, 1, 3, 9)]
        [InlineData(7, 1, 5, 3)]
        public void AllNumbers_AreOdd_WithInlineData(int a, int b, int c, int d)
        {
            Assert.True(IsOddNumber(a));
            Assert.True(IsOddNumber(b));
            Assert.True(IsOddNumber(c));
            Assert.True(IsOddNumber(d));
        }
    }

 /*public    class FirstDeep
    {
        private ISecondDeep oa;

        public FirstDeep(ISecondDeep oa)
        {
            this.oa = oa;
        }

        public string AddA(string str)
        {
            return String.Concat(str, oa.SomethingToDo(str) ? "AAA" : "BBB");
        }
    }
  public   interface ISecondDeep
    {
        bool SomethingToDo(string str);
    }

    class SecondDeep : ISecondDeep
    {
        public bool SomethingToDo(string str)
        {
            bool flag = false;
            if (str.Length < 10)
            {
                // without abstraction your test will require database
            }
            return flag;
        }
    }

    public class Tests
    {
        [Fact]
        public void AddAAATest()
        {
            // Arrange
            Mock<ISecondDeep> secondDeep = new Mock<ISecondDeep>();
            secondDeep.Setup(x => x.SomethingToDo(It.IsAny<string>())).Returns(true);
            // Act
            FirstDeep fd = new FirstDeep(secondDeep.Object);
            // Assert
            Assert.Equal("ABCAAA", fd.AddA("ABCAAA"));
        }
    }*/
}
