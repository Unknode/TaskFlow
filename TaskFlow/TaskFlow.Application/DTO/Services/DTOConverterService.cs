using TaskFlow.Domain.Model;
using Task = TaskFlow.Domain.Model.Task;

namespace TaskFlow.Application.DTO.Services
{
    public class DTOConverterService
    {
        public DTOConverterService() { }

        public TaskDTO ConvertTaskToDTO(Task task)
        {
            if (task == null)
                return null;

            return new TaskDTO
            {
                CreatedAt = task.CreatedAt,
                Id = task.Id,
                LastUpdatedAt = task.LastUpdatedAt,
                Priority = task.Priority,
                TaskItems = task.TaskItems.Select(x => ConvertTaskItemToDTO(x)).ToList()
            };
        }

        public Task ConvertTaskDTOToTask(TaskDTO taskDTO)
        {
            if (taskDTO == null)
                return null;

            return new Task
            {
                CreatedAt = taskDTO.CreatedAt,
                Id = taskDTO.Id,
                LastUpdatedAt = taskDTO.LastUpdatedAt,
                Priority = taskDTO.Priority,
                TaskItems = taskDTO.TaskItems.Select(x => ConvertTaskItemDTOToTaskItem(x)).ToList()
            };
        }

        public TaskItemDTO ConvertTaskItemToDTO(TaskItem taskItem)
        {
            if (taskItem == null)
                return null;

            return new TaskItemDTO
            {
               Description = taskItem.Description,
               Id = taskItem.Id,
               Name = taskItem.Name,
               Status = taskItem.Status
            };
        }

        public TaskItem ConvertTaskItemDTOToTaskItem(TaskItemDTO taskItemDTO)
        {
            if (taskItemDTO == null)
                return null;

            return new TaskItem
            {
                Description = taskItemDTO.Description,
                Id = taskItemDTO.Id,
                Name = taskItemDTO.Name,
                Status = taskItemDTO.Status
            };
        }

        public UserDTO ConvertUserToUserDTO(User user) 
        {
            if (user == null)
                return null;

            return new UserDTO
            {
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
                Password = user.Password
            };
        }

        public User ConvertUserDTOToUser(UserDTO userDTO)
        {
            if (userDTO == null)
                return null;

            return new User
            {
                Email = userDTO.Email,
                Id = userDTO.Id,
                Name = userDTO.Name,
                Password = userDTO.Password
            };
        }
    }
}
