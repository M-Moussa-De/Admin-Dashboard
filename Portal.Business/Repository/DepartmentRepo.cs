using Microsoft.EntityFrameworkCore;
using Portal.Business.Interface;
using Portal.Business.Models;
using Portal.Infrastructure.Data;

namespace Portal.Business.Repository
{
    public class DepartmentRepo : IDepartmentRepo
    {
        ApplicationContext db = new ApplicationContext();
        public async Task<List<DepartmentVM>> GetAsync()
        {
            var data = await db.Departments.Select(a =>
             new DepartmentVM()
             {
                 Id = a.Id,
                 Name = a.Name,
                 Code = a.Code
             }).ToListAsync();
            
            return data;
        }
    }
}
