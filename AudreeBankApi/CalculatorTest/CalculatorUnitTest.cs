using System;
using Xunit;
using MyCalculator;

namespace CalculatorTest
{
    public class CalculatorUnitTest
    {
        [Fact]
        public void sum_of_100_and_200_should_be_300()
        {
            int a = 100;
            int b = 200;
            int extected = 300;
            int actual = SimpleCalculator.Add(a, b);
            Assert.Equal(extected, actual);
        }

        [Fact]
        public void add_should_return_integer()
        {
            int a = 100;
            int b = 200;
            int actual = SimpleCalculator.Add(a, b);
            Assert.IsType(typeof(int), actual);
        }
    }
}
