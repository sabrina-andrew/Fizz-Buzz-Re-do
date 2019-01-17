using System;
using Xunit;

namespace FizzBuzz.Test
{
    public class Get_Returns_1_For_1()
    {
        [Fact]
        public void Test1()
        {

        //Arrange
        FizzBuzz underTest = new FizzBuzz();

        //Act
        string result = underTest.Get(1);

        //Assert
        Assert.Equal("1", result);
    }
    }
}
