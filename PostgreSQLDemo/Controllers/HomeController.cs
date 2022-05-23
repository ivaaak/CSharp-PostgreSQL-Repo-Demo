using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PostgreSQLDemo.Data;
using PostgreSQLDemo.ViewModels;

namespace PostgreSQLDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext context;

        public HomeController(DataContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var users = this.context.Users.Include(m => m.Addresses).Select( m => new UserViewModel 
            {
                FirstName = m.FirstName,
                LastName = m.LastName,
                PhoneNumber = m.PhoneNumber,
                Role = m.Role,
                Address = string.Join(',', m.Addresses.Select(a => a.City))
            });

            return View(users);
        }
    }
}