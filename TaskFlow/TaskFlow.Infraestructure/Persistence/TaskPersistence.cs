using TaskFlow.Domain.Model;
using TaskFlow.Domain.Services.Interfaces;
using TaskFlow.Infraestructure.Context;

namespace TaskFlow.Infraestructure.Persistence
{
    public class TaskPersistence : ITaskPersistence
    {
        private readonly MySqlContext taskContext;
        public void CreateTask(TaskModel task)
        {
            if (task == null)
                return;

            taskContext.Tasks.Add(task);
            taskContext.SaveChanges();
        }

        public void DeleteTask(TaskModel task)
        {
            if (task == null)
                return;

            taskContext.Tasks.Remove(task);
            taskContext.SaveChanges();
        }

        public TaskModel GetTask(int id)
        {
            if (id == 0)
                return null;

           return taskContext.Tasks.FirstOrDefault(x => x.Id == id);
        }

        public TaskModel UpdateTask(TaskModel task)
        {
            if (task == null)
                return null;

            taskContext.Tasks.Update(task);
            taskContext.SaveChanges();

            return task;
        }
    }
}
