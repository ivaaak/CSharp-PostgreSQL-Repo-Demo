using System.ComponentModel.DataAnnotations;

namespace PostgreSQLDemo.Data.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        public string? Street { get; set; }

        public int StreetNumber { get; set; }

        public string? City { get; set; }

        public int ZipCode { get; set; }

        public string? Country { get; set; }
    }
}
