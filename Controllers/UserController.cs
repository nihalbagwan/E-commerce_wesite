using DemoProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }
    }
}
