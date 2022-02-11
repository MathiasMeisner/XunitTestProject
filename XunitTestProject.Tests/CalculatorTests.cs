using System;
using Xunit;

namespace XunitTestProject.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        public void Add_ShouldCalculate(double x, double y, double expected)
        {
            // Arrange


            // Act
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]
        public void Divide_ShouldCalculate(double x, double y, double expected)
        {
            // Act
            double actual = Calculator.Divide(x, y);

            // Assert

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Calculator.Divide(15, 0);

            // Assert

            Assert.Equal(expected, actual);
        }
    }
}
