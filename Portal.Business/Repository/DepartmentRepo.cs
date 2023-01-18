using Microsoft.EntityFrameworkCore;
using Portal.Business.Interface;
using Portal.Business.Models;
using Portal.Infrastructure.Data;
using Portal.Infrastructure.Entities;

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


		public async Task<DepartmentVM> GetByIdAsync(int id)
		{
			var data = await db.Departments.Where(a => a.Id == id).Select(a => new DepartmentVM()
			{
				Id = a.Id,
				Name = a.Name,
				Code = a.Code

			}).SingleOrDefaultAsync();

     		return data;
		}


		public async Task SaveAsync(DepartmentVM obj)
		{
			var department = new Department()
			{
				Id = obj.Id,
				Name = obj.Name,
				Code = obj.Code
			};

			await db.Departments.AddAsync(department);

			await db.SaveChangesAsync();
		}

		public async Task EditAsync(DepartmentVM obj)
		{
			var oldData = db.Departments.Find(obj.Id);

			if (oldData != null)
			{
				oldData.Name = obj.Name;
				oldData.Code = obj.Code;
				await db.SaveChangesAsync();

			}
		}

		public async Task DeleteAsync(DepartmentVM obj)
		{
			var oldData = db.Departments.Find(obj.Id);

			if (oldData != null)
			{
				db.Departments.Remove(oldData);
				await db.SaveChangesAsync();
			}
		}
	}
}
