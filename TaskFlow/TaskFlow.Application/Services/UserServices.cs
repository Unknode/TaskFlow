using TaskFlow.Application.DTO;
using TaskFlow.Application.DTO.Services;
using TaskFlow.Domain.Services;

namespace TaskFlow.Application.Services
{
    public class UserServices
    {
        private readonly UserPersistenceServices _userPersistence;
        private readonly DTOConverterService _dtoConverterService;
        public UserDTO GetUser(string email, HashCode password) 
        {
            if (email == null)
                return null;

            var user = _dtoConverterService.ConvertUserToUserDTO(_userPersistence.GetUser(email, password));

            return user;
        }

        public UserDTO UpdateUserEmail(string newEmail, UserDTO userDto)
        {
            if (userDto == null)
                return null;

            var user = _userPersistence.UpdateUserEmail(newEmail, _dtoConverterService.ConvertUserDTOToUser(userDto));

            return _dtoConverterService.ConvertUserToUserDTO(user);
        }

        public UserDTO UpdateUserPassword(HashCode newPassword, UserDTO userDto)
        {
            if (userDto == null)
                return null;

            var user = _userPersistence.UpdateUserPassword(newPassword, _dtoConverterService.ConvertUserDTOToUser(userDto));

            return _dtoConverterService.ConvertUserToUserDTO(user);
        }
    }
}
