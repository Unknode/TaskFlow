using Microsoft.VisualBasic;
using TaskFlow.Application.DTO;
using TaskFlow.Application.DTO.Services;
using TaskFlow.Domain.Services;

namespace TaskFlow.Application.Services
{
    public class TaskServices
    {
        private readonly DTOConverterService _dtoConverter;
        private readonly TaskPersistenceServices _taskPersistence;

        public void CreateTask (TaskDTO taskDto)
        {
            if (taskDto == null)
                return;

            var task = _dtoConverter.ConvertTaskDTOToTask(taskDto);

            if (task == null)
                return;

            _taskPersistence.CreateTask(task);
        }

        public TaskDTO UpdateTask (TaskDTO taskDto)
        {
            if (taskDto == null)
                return null;

            var task = _dtoConverter.ConvertTaskDTOToTask(taskDto);

            return _dtoConverter.ConvertTaskToDTO(_taskPersistence.UpdateTask(task));
        }

        public void DeleteTask(string id) 
        {
            _taskPersistence.DeleteTask(id);
        }

        public TaskDTO GetTask(string id) 
        { 
            var task = _taskPersistence.GetTask(id);

            if (task == null)
                return null;

            return _dtoConverter.ConvertTaskToDTO(task);
        }
    }
}
