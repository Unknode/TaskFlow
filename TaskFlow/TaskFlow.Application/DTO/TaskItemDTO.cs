using TaskFlow.Domain.Model.Enum;

namespace TaskFlow.Application.DTO
{
    public class TaskItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }

    }
}
