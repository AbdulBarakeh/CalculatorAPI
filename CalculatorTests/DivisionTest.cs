using Calculator.Controllers;
using Calculator.Models;

namespace CalculatorTests
{
    public class DivisionTest
    {
        [Fact]
        public void DividingNumbersGivesCorrectResult()
        {
            var calculator = new CalculatorController();

            var result = calculator.Division(new CalculationRequest { Number1 = 10, Number2 = 4 });

            Assert.Equal((decimal)2.5, result.Result);
        }
    }
}