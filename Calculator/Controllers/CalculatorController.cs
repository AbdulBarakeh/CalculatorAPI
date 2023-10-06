using Calculator.Models;
using Calculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        public Calculator.Services.ILogger Logger { get; set; }
        public CalculatorController(Calculator.Services.ILogger logger)
        {
            Logger = logger;
        }
        [Route("Addition")]
        [HttpPost()]
        public CalculationResult Addition([FromBody] CalculationRequest request)
        {

            Logger.LogToSql($"Adding {request.Number1} to {request.Number2}");

            return new CalculationResult
            {
                Result = request.Number1 + request.Number2,
            };
        }
    }
}