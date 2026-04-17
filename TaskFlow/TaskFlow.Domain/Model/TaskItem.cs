using TaskFlow.Domain.Model.Enum;

namespace TaskFlow.Domain.Model
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }

        public TaskItem() { }
    }
}
