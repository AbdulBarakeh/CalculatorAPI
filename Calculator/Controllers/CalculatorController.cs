using Calculator.Models;
using Calculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [Route("Addition")]
        [HttpPost()]
        public CalculationResult Addition([FromBody] CalculationRequest request)
        {
            var logger = new SqlLogger();

            logger.LogToSql($"Adding {request.Number1} to {request.Number2}");

            return new CalculationResult
            {
                Result = request.Number1 + request.Number2,
            };
        }

        [Route("AdditionMultipleNumbers")]
        [HttpPost()]
        public CalculationResult Addition([FromBody] CalculationRequestMultiNum request)
        {
            var logger = new SqlLogger();
            logger.LogToSql($"Adding following numbers together: {String.Join(",", request.Numbers)}");

            return new CalculationResult
            {
                Result = request.Numbers.Sum()
            };
        }
    }
}