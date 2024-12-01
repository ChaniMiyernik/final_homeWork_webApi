namespace lesson3.Model
{
    public class Project
    {
        public int id { get; set; }
        public string projectName { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
    }
}
