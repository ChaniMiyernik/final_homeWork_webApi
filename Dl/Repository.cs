using lesson3.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Expressions;
using System.Data;


namespace lesson3.Dl
{
    public class Repository : IRepository
    {
        private readonly TaskDbContext _context;
        public Repository(TaskDbContext context)
        {
            _context = context;
        }
       

        public void UpdateTask(Tasks task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();
            
        }

        public Tasks CreateTask(Tasks task)
        {
            _context.Tasks.Add(task);
           
            _context.SaveChanges();
            return task;
        }

        public IEnumerable<Tasks> GetAllTasks()
        {
            return _context.Tasks.ToList();
        }

        public IEnumerable<Tasks> Delete(Tasks task)
        {

            _context.Tasks.Remove(task);
            _context.SaveChanges();
            return _context.Tasks.ToList();
        }

        public IEnumerable<Tasks> GetTasksByuserId(int id)
        {
            IEnumerable<Tasks> tasks = _context.Tasks.Where(t => t.userId == id).Select(t => t).ToList();
            if(tasks!=null)
            {
                return tasks;
            }
            return null;
        }
        public bool ExistUser(int id)
        {
            User user = _context.User.FirstOrDefault(u => u.id == id);
            if(user!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ExistProject(int id)
        {
            Project project = _context.Project.FirstOrDefault(u => u.id == id);
            if (project != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
//StatusCodes.Status400BadRequest<>
