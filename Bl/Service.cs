using lesson3.Dl;
using lesson3.Model;
using lesson3.Bl.Loger;
namespace lesson3.Bl
{
    public class Service : IService
    {
        private readonly IRepository _repository;
        private readonly ILoggerService _logger;
        private readonly Loger.LoggerFactory _loggerFactory;
        public Service(IRepository repository, Loger.LoggerFactory loggerFactory)
        {
            _repository = repository;
            _loggerFactory = loggerFactory;
            _logger = _loggerFactory.GetLogger("Data Base");
        }
        public Tasks UpdateTasks(Tasks task)
        {
            _repository.UpdateTask(task);
            return task;
        }
        public Tasks createTask(Tasks task)
        {
            bool flag = _repository.ExistUser(task.UserId);
            if(flag)
            {
                 Tasks newTask = new Tasks();
                 newTask.Id = task.Id;
                 newTask.Date = task.Date;
                 newTask.Status = task.Status;
                 newTask.UserId = task.UserId;
                 newTask.ProjectId = task.ProjectId;
                 return _repository.CreateTask(newTask);
            }
            return null;
        }
        public IEnumerable<Tasks> GetAllTasks()
        {
            _logger.Log("Get All Tasks!");
            return _repository.GetAllTasks();
        }
        public IEnumerable<Tasks> Delete(int id)
        {
            IEnumerable<Tasks> tasks = _repository.GetAllTasks();
            Tasks task = tasks.FirstOrDefault(t => t.Id == id);
            if(task!=null)
                return _repository.Delete(task);
            return null;
        }
        public IEnumerable<Tasks> GetTasksByuserId(int id)
        {
            return _repository.GetTasksByuserId(id);
        }
    }
}
