using Calculator.Controllers;
using Calculator.Models;
using Calculator.Services;
using Moq;

namespace CalculatorTests
{
    public class AdditionTest
    {

        [Fact]
        public void AddingNumbersGivesCorrectResult()
        {
            //mocking logger due to not being unit under test
            var logger = Mock.Of<ILogger>();
            var calculator = new CalculatorController(logger);

            var result = calculator.Addition(new CalculationRequest { Number1 = 1, Number2 = 2 });

            Assert.Equal(3, result.Result);
        }
    }
}