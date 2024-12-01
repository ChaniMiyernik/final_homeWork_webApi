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
            _logger = _loggerFactory.GetLogger("console");
        }
        public Tasks UpdateTasks(Tasks task)
        {
            _repository.UpdateTask(task);
            return task;
        }
        public Tasks createTask(Tasks task)
        {
            bool flag = _repository.ExistUser(task.userId);
            if(flag)
            {
                 Tasks newTask = new Tasks();
                 newTask.id = task.id;
                 newTask.dueDate = task.dueDate;
                 newTask.status = task.status;
                newTask.userId = task.userId;
                newTask.projectId = task.projectId;
                 return _repository.CreateTask(newTask);
            }
            return null;
        }

        public IEnumerable<Tasks> GetAllTasks()
        {
            _logger.Log("doneeeeeeeee!");
            return _repository.GetAllTasks();

        }

        public IEnumerable<Tasks> Delete(int id)
        {
            IEnumerable<Tasks> tasks = _repository.GetAllTasks();
            Tasks task = tasks.FirstOrDefault(t => t.id == id);
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
