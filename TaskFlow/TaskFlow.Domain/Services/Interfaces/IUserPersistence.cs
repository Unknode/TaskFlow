using TaskFlow.Domain.Model;

namespace TaskFlow.Domain.Services.Interfaces
{
    public interface IUserPersistence
    {
        public User GetUser(string email, HashCode password);

        public User UpdateUserEmail(string newEmail, User authUser);

        public User UpdateUserPassword(HashCode newPassword, User authUser);
    }
}
