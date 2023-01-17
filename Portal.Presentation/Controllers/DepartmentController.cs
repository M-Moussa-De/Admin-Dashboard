using Microsoft.AspNetCore.Mvc;
using Portal.Business.Repository;

namespace Portal.Presentation.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentRepo repo = new DepartmentRepo();
        
        public async Task<IActionResult> Index()
        {
            var depts = await repo.GetAsync();

            return View(depts);
        }
    }
}
