using Portal.Business.Models;

namespace Portal.Business.Interface
{
    public interface IDepartmentRepo
    {
        Task<List<DepartmentVM>> GetAsync();

        Task<DepartmentVM> GetByIdAsync(int id);
        
        Task SaveAsync(DepartmentVM obj);
        
        Task EditAsync(DepartmentVM obj);
        
        Task DeleteAsync(DepartmentVM obj);
    }
}
