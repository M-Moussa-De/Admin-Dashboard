using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portal.Business.Models;
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

		public async Task<IActionResult> Show(int id)
		{
			var dep = await repo.GetByIdAsync(id);

			if (dep == null)
			{
				return RedirectToAction("Index", "NotFound");
			}

			return View(dep);
		}

		[HttpGet]
		public IActionResult New()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> New(DepartmentVM model)
		{
			try
			{
				// Validation checking
				if (ModelState.IsValid)
				{
					await repo.SaveAsync(model);
				}

				return RedirectToAction("Index", "Department");
			}
			catch (Exception)
			{
				TempData["Error"] = "Error occured while saving the data into DB";
			}

			return View();
		}

		[HttpGet]
		public IActionResult Edit()
		{
			return View();
		}

		//[HttpPost]
		//public async Task<IActionResult> Edit(int id)
		//{
		//	var dep = repo.GetByIdAsync(id);

		//	if (dep == null)
		//	{
		//		return RedirectToAction("Index", "NotFound");
		//	}



		//	await repo.EditAsync(dep);
		//}

		[Route("api/[controller]")]
		[HttpGet("{depname}")]
		public async Task DepName(string name)
		{
			return await repo.FindAsync(name);
		}


	}
}
