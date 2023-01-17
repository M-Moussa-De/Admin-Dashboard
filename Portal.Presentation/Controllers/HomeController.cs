using Microsoft.AspNetCore.Mvc;

namespace Portal.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}