using Microsoft.AspNetCore.Mvc;

namespace DHL_ecommerce_login_page.Controllers
{
    public class AccountController : Controller
    {
        private const string Username = "admin";
        private const string Password = "admin123";

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if(username == Username && password == Password)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.ErrorMessage = "Invalid Username or Password";
            return View();
        }
    }
}