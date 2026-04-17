using TaskFlow.Domain.Model;
using TaskFlow.Domain.Model.Enum;

namespace TaskFlow.Application.DTO
{
    public class TaskDTO
    {
        public int Id { get; set; }
        public Priority Priority { get; set; }
        public List<TaskItemDTO> TaskItems { get; set; } = new List<TaskItemDTO>();
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;
    }
}
