namespace lesson3.Model
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
    }
}
