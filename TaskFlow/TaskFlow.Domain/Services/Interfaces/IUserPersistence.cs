using TaskFlow.Domain.Model;

namespace TaskFlow.Domain.Services.Interfaces
{
    public interface IUserPersistence
    {
        public User GetUser(string email, string hashedPassword);

        public User UpdateUserEmail(string newEmail, User authUser);

        public User UpdateUserPassword(string hashedPassword, User authUser);
    }
}
