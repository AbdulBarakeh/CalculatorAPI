using System.Diagnostics;

namespace Calculator.Services
{
    public class Logger : ILogger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine(message);
        }

        public void LogToFile(string message, string filepath)
        {
            throw new NotImplementedException();
        }

        public void LogToSql(string message)
        {
            // Code removed for clearity
        }
    }
}