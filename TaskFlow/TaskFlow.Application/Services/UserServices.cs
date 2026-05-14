using TaskFlow.Application.DTO;
using TaskFlow.Application.DTO.Services;
using TaskFlow.Domain.Services;
using TaskFlow.Domain.Services.Interfaces;

namespace TaskFlow.Application.Services
{
    public class UserServices
    {
        private readonly IUserPersistence _userPersistence;
        private readonly DTOConverterService _dtoConverterService;
        public UserDTO GetUser(string email, string password) 
        {
            if (email == null)
                return null;

            var hashedPassword = AuthService.HashPassword(password);

            var user = _dtoConverterService.ConvertUserToUserDTO(_userPersistence.GetUser(email, hashedPassword));

            return user;
        }

        public UserDTO UpdateUserEmail(string newEmail, UserDTO userDto)
        {
            if (userDto == null)
                return null;

            var user = _userPersistence.UpdateUserEmail(newEmail, _dtoConverterService.ConvertUserDTOToUser(userDto));

            return _dtoConverterService.ConvertUserToUserDTO(user);
        }

        public UserDTO UpdateUserPassword(string newPassword, UserDTO userDto)
        {
            if (userDto == null)
                return null;

            var user = _userPersistence.UpdateUserPassword(newPassword, _dtoConverterService.ConvertUserDTOToUser(userDto));

            return _dtoConverterService.ConvertUserToUserDTO(user);
        }
    }
}
