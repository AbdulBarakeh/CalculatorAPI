using Calculator.Controllers;
using Calculator.Models;
using Calculator.Services;
using Moq;

namespace CalculatorTests
{
    public class FileLoggingTest
    {
        [Fact]
        public void MessageIsWrittenInFile()
        {
            var logger = Mock.Of<ILogger>();
            logger.LogToFile("Test", "./Logfile.txt");

            var fileLines = File.ReadLines("./Logfile.txt");

            Assert.Contains(fileLines.Last(), "Test");
        }
    }
}