using CalculatorOO.Domain;
using Xunit;

namespace CalculatorOO.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void MustSome()
        {
            var calc = new Calculator();

            Assert.Equal(4, calc.Some(2, 2));
        }
        [Fact]
        public void MustSubtract()
        {
            var calc = new Calculator();

            Assert.Equal(0, calc.Subtract(2, 2));
        }
        [Fact]
        public void MustMultiply()
        {
            var calc = new Calculator();

            Assert.Equal(4, calc.Multiply(2, 2));
        }
        [Fact]
        public void MustDivide()
        {
            var calc = new Calculator();

            Assert.Equal(1, calc.Divide(2, 2));
        }
    }
}