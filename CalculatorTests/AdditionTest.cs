using Calculator.Controllers;
using Calculator.Models;

namespace CalculatorTests
{
    public class AdditionTest
    {
        [Fact]
        public void AddingNumbersGivesCorrectResult()
        {
            var calculator = new CalculatorController();

            var result = calculator.Addition(new CalculationRequest { Number1 = 1, Number2 = 2 });

            Assert.Equal(3, result.Result);
        }

        [Fact]
        public void AddingNumbersFromListGivesCorrectResult()
        {
            var calculator = new CalculatorController();

            var result = calculator.Addition(new CalculationRequestMultiNum { Numbers = new List<decimal>() { 1, 2 } });

            Assert.Equal(3, result.Result);
        }
    }
}