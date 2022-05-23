using PostgreSQLDemo.Data;
using PostgreSQLDemo.Data.Models;

namespace PostgreSQLDemo
{
    public static class DataSeeder
    {
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<DataContext>();
            context.Database.EnsureCreated();
            AddUsers(context);
        }

        private static void AddUsers(DataContext context)
        {
            var user = context.Users.FirstOrDefault();
            if (user != null) return;

            context.Users.Add(new User
            {
                FirstName = "Antonia",
                LastName = "Gonzales",
                PhoneNumber = 11321394,
                Addresses = new List<Address>
                {
                    new Address { Street = "Emilio Mateo 6"},
                    new Address { Street = "Ana María Guzmán 4"}
                }
            });

            context.Users.Add(new User
            {
                FirstName = "Ramón",
                LastName = "Pichardo",
                PhoneNumber = 12345,
                Addresses = new List<Address>
                {
                    new Address { Street = "Mariana Sánchez 6"},
                    new Address { Street = "Rodrigo Quiroz 4"}
                }
            });

            context.Users.Add(new User
            {
                FirstName = "Verónica",
                LastName = "Pichardo",
                PhoneNumber = 12345,
                Addresses = new List<Address>
                {
                    new Address { Street = "Diana Luevano 6"},
                    new Address { Street = "Sara Soto 4"}
                }
            });
            context.Users.Add(new User
            {
                FirstName = "Sergio",
                LastName = "Alarcón",
                PhoneNumber = 12345,
                Addresses = new List<Address>
                {
                    new Address { Street = "Mariana Sánchez 6"},
                    new Address { Street = "Rodrigo Quiroz 4"}
                }
            });
            context.Users.Add(new User
            {
                FirstName = "Ignacio",
                LastName = "Terán",
                PhoneNumber = 12345,
                Addresses = new List<Address>
                {
                    new Address { Street = "Octavio Valle 6"},
                }
            });
            context.Users.Add(new User
            {
                FirstName = "Ramón",
                LastName = "Pichardo",
                PhoneNumber = 12345,
                Addresses = new List<Address>
                {
                    new Address { Street = "Mariana Sánchez 6"},
                    new Address { Street = "Rodrigo Quiroz 4"}
                }
            });


            context.SaveChanges();
        }
    }
}
