namespace TaskFlow.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public HashCode Password { get; set; } 

       public User (string name, string email, HashCode password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public User (string email, HashCode password)
        {
            Name = "";
            Email = email;
            Password = password;
        }

        public User() { }
    }
}
