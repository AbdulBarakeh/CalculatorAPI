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
        [Route("Division")]
        [HttpPost()]
        public CalculationResult Division([FromBody] CalculationRequest request)
        {
            var logger = new SqlLogger();

            logger.LogToSql($"Dividing {request.Number1} with {request.Number2}");

            return new CalculationResult
            {
                Result = request.Number1 / request.Number2,
            };
        }
    }
}