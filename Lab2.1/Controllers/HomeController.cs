using Microsoft.AspNetCore.Mvc;

namespace MathServiceApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
