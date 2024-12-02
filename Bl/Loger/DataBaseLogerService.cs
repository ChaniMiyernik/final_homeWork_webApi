using lesson3.Dl;
using lesson3.Model;
namespace lesson3.Bl.Loger
{
    public class DataBaseLogerService : ILoggerService
    {
        private readonly TaskDbContext _context;
        public DataBaseLogerService(TaskDbContext context)
        {
            _context = context;
        }
        public void Log(string message)
        {
            Logger logger = new Logger();
            logger.Log = message;
            _context.Logger.Add(logger);
            _context.SaveChanges();
        }
    }
}
