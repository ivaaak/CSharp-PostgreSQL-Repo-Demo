using Microsoft.EntityFrameworkCore;
using PostgreSQLDemo.Data.Models;

namespace PostgreSQLDemo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }
    }
}
