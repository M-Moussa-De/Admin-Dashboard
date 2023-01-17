using Microsoft.EntityFrameworkCore;
using Portal.Infrastructure.Entities;

namespace Portal.Infrastructure.Data
{
    public partial class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=portalDb;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true");
        }
    }

    public partial class ApplicationContext
    {
        public DbSet<Department> Departments { get; set; }
    }
}
