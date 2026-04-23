using Microsoft.EntityFrameworkCore;
using TaskFlow.Domain.Model;
namespace TaskFlow.Infraestructure.Context
{
    public class MySqlContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }

        public MySqlContext(DbContextOptions<MySqlContext> options) : base (options) 
        {

        }
    }
}
