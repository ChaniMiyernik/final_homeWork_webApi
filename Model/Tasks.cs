namespace lesson3.Model
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string? Title { get; set; }
        public string? Status { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
    }
}
