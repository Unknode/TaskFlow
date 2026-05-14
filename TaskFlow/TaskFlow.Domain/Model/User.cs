namespace TaskFlow.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; } 

       public User (string name, string email, string hashedPassword)
        {
            Name = name;
            Email = email;
            HashedPassword = hashedPassword;
        }

        public User (string email, string hashedPassword)
        {
            Name = "";
            Email = email;
            HashedPassword = hashedPassword;
        }

        public User() { }
    }
}
