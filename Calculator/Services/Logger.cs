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
            //No need to make the file logging async, due to being a singleton
            File.AppendAllText(filepath, $"\n{message}");
        }

        public void LogToSql(string message)
        {
            // Code removed for clearity
        }
    }
}