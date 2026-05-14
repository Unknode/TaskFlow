using TaskFlow.Domain.Model;
using TaskFlow.Domain.Services.Interfaces;
using TaskFlow.Infraestructure.Context;

namespace TaskFlow.Infraestructure.Persistence
{
    public class UserPersistence : IUserPersistence
    {
        private readonly MySqlContext taskContext;
        public User GetUser(string email, string hashedPassword)
        {
            if (String.IsNullOrEmpty(email)|| String.IsNullOrEmpty(hashedPassword)) {
                return null;
            }
            var user = taskContext.Users.FirstOrDefault(x => x.Email == email && x.HashedPassword == hashedPassword);

            return user;
        }

        public User UpdateUserEmail(string newEmail, User authUser)
        {
            var updatedUser = taskContext.Users.FirstOrDefault(x => x.Email == authUser.Email);

            if (updatedUser == null)
                return null;

            updatedUser.Email = newEmail;

            taskContext.Users.Update(updatedUser);
            taskContext.SaveChanges();

            return updatedUser;
        }

        public User UpdateUserPassword(string hashedPassword, User authUser)
        {
            return null;
        }
    }
}
