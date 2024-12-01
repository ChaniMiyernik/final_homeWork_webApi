namespace lesson3.Model
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
    }
}
