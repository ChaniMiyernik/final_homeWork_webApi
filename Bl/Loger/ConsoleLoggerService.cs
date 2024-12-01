namespace lesson3.Bl.Loger
{
    public class ConsoleLoggerService : ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log:{message}");
        }
    }
}
