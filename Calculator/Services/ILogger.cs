namespace Calculator.Services
{
    public interface ILogger
    {
        void LogToSql(string message);
        void LogToConsole(string message);
        void LogToFile(string message, string filepath);
    }
}
