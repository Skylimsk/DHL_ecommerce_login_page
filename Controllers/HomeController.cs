using Microsoft.AspNetCore.Mvc;

namespace DHL_ecommerce_login_page.Controllers
{

    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        
    }
}


