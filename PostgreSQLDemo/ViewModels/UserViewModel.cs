using PostgreSQLDemo.Data;

namespace PostgreSQLDemo.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int PhoneNumber { get; set; }

        public string? Role { get; set; }

        public string? Address { get; set; }
    }
}
