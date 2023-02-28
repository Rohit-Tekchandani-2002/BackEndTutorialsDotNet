using LoginApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LoginApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly UsersContext _context;

        public LoginController(UsersContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                ViewBag.Error = "Invalid username or password.";
                return View();
            }

            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool ValidateCredentials(string username, string password)
            {
                var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
                return user != null;
            }

            // Validate the user credentials
            bool success = ValidateCredentials(model.Username, model.Password);

            if (success)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["Error"] = "Invalid username or password.";
                return View(model);
            }
        }

    }
}
