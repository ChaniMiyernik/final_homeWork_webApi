using lesson3.Model;

namespace lesson3.Bl
{
    public interface IService
    {
        Tasks createTask(Tasks task);
        IEnumerable<Tasks> GetAllTasks();
        Tasks UpdateTasks(Tasks task);
        IEnumerable<Tasks> Delete(int id);
        IEnumerable<Tasks> GetTasksByuserId(int id);

    }
}