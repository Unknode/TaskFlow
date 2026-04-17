namespace TaskFlow.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public HashCode Password { get; set; } 

        public User() { }
    }
}
