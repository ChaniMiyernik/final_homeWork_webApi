using lesson3.Model;
using Microsoft.EntityFrameworkCore;

namespace lesson3.Dl
{
    public class TaskDbContext:DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Logger> Logger { get; set; }
    }
}
