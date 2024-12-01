using lesson3.Model;

namespace lesson3.Dl
{
    public interface IRepository
    {
        void UpdateTask(Tasks tasks);
        Tasks CreateTask(Tasks task);
        IEnumerable<Tasks> GetAllTasks();
        IEnumerable<Tasks> Delete(Tasks task);
        IEnumerable<Tasks> GetTasksByuserId(int id);
        bool ExistUser(int id);
        bool ExistProject(int id);

    }
}