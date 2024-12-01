using lesson3.Bl.Loger;

namespace lesson3.Bl.Loger
{
    public class LoggerFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public LoggerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ILoggerService GetLogger(string useLogger)
        {
            if (useLogger=="file")
            {
                return _serviceProvider.GetRequiredService<FileLoggerService>();
            }
            else if(useLogger=="console")
            {
                return _serviceProvider.GetRequiredService<ConsoleLoggerService>();
            }
            else
            {
                return _serviceProvider.GetRequiredService<DataBaseLogerService>();
            }
        }
    }
}
