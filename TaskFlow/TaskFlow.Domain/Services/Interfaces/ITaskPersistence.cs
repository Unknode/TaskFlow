using TaskFlow.Domain.Model;

namespace TaskFlow.Domain.Services.Interfaces
{
    public interface ITaskPersistence
    {
        public void CreateTask(TaskModel task);

        public TaskModel UpdateTask(TaskModel task);

        public void DeleteTask(TaskModel task);

        public TaskModel GetTask(int id);
    }
}
