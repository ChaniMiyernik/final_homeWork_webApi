namespace lesson3.Model
{
    public class Tasks
    {
        public int id { get; set; }
        public DateTime? dueDate { get; set; }
        public string? title { get; set; }
        public string? status { get; set; }
        public int projectId { get; set; }
        public int userId { get; set; }
    }
}
