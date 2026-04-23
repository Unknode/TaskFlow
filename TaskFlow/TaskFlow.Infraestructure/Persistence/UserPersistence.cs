using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFlow.Domain.Model;
using TaskFlow.Domain.Services.Interfaces;
using TaskFlow.Infraestructure.Context;

namespace TaskFlow.Infraestructure.Persistence
{
    public class UserPersistence : IUserPersistence
    {
        private readonly MySqlContext taskContext;
        public User GetUser(string email, HashCode password)
        {
            if (email == null || password ==)
            var authUser = taskContext.Users.FirstOrDefault(x => x.Email == email && x.Password == password);

            return authUser;
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

        public User UpdateUserPassword(HashCode newPassword, User authUser)
        {
            return null;
        }
    }
}
