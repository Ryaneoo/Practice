namespace _2401377C.Domain
{
    public class MyTask
    {
        public int Id { get; set; }
        public string? TaskName { get; set; }

        public bool IsCompleted { get; set; }
        
        public DateTime DueDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
