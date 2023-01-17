using Microsoft.AspNetCore.Mvc;

namespace Portal.Presentation.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            Employee emp1 = new Employee()
            {
                Id = 1,
                Name = "Mark",
                Salary = 1500
            };

            Employee emp2 = new Employee()
            {
                Id = 2,
                Name = "Rebecca",
                Salary = 1350
            };

            Employee emp3 = new Employee()
            {
                Id = 3,
                Name = "Alejandra",
                Salary = 1750
            };

            Employee emp4 = new Employee()
            {
                Id = 4,
                Name = "Markous",
                Salary = 1890
            };

            Employee emp5 = new Employee()
            {
                Id = 5,
                Name = "Alessandro",
                Salary = 3200
            };

            List<Employee> emps = new List<Employee>();

            emps.Add(emp1);
            emps.Add(emp2);
            emps.Add(emp3);
            emps.Add(emp4);
            emps.Add(emp5);

            return View(emps);
        }
    }
}
