namespace TaskFlow.Application.Services
{
    public class AuthService
    {
        public AuthService() { }

        public static bool ValidatePassword(string password, string userPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, userPassword);
        }

        public static string HashPassword (string password) 
        {
            return BCrypt.Net.BCrypt.HashPassword(password, 12);
        }
    }
}
