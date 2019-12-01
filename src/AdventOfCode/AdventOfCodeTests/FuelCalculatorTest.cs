using AdventOfCode.Modules;
using System;
using Xunit;

namespace AdventOfCodeTests
{
    public class FuelCalculatorTest
    {
        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void CalculateShouldReturnExpectedFuelValue(int input, int expected)
        {
            // Arrange
            var fuel = new FuelCalculator();

            // Act 
            var calculatedFuel = fuel.Calculate(input);

            // Assert
            Assert.Equal(expected, calculatedFuel);
        }

        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 966)]
        [InlineData(100756, 50346)]
        public void SumOfMassRequirementsShouldReturnExpectedValues(int input, int expected)
        {
            // Arrange
            var fuel = new FuelCalculator();

            // Act 
            var sumOfFuel = fuel.SumOfMassRequirements(input);

            // Assert
            Assert.Equal(expected, sumOfFuel);
        }
    }
}
