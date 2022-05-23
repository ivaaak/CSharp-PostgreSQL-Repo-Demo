using System.ComponentModel.DataAnnotations;

namespace PostgreSQLDemo.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        public int PhoneNumber { get; set; }

        public string? Role { get; set; }

        [MaxLength(3)]
        public List<Address>? Addresses { get; set; }
    }
}
