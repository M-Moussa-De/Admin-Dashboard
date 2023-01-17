using Portal.Business.Models;

namespace Portal.Business.Interface
{
    public interface IDepartmentRepo
    {
        Task<List<DepartmentVM>> GetAsync();
    }
}
