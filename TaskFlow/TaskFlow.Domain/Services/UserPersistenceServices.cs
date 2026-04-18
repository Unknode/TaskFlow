using TaskFlow.Domain.Model;

namespace TaskFlow.Domain.Services
{
    public class UserPersistenceServices
    {
        public User GetUser(string email, HashCode password)
        {
            if (email == null)
                return null;

            return new User(email, password);
        }

        public User UpdateUserEmail(string newEmail, User authUser)
        {
            if (authUser == null)
                return null;

            return authUser;
        }

        public User UpdateUserPassword(HashCode newPassword, User authUser)
        {
            if (authUser == null)
                return null;

            return authUser;
        }
    }
}
