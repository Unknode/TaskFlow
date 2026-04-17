using TaskFlow.Domain.Model.Enum;

namespace TaskFlow.Domain.Model
{
    public class Task
    {
        public int Id { get; set; }
        public Priority Priority { get; set; }
        public List<TaskItem> TaskItems { get; set; } = new List<TaskItem>();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;
        public Task() { }
    }
}
