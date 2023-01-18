using Microsoft.AspNetCore.Mvc;

namespace Portal.Presentation.Controllers
{
	public class NotFoundController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
