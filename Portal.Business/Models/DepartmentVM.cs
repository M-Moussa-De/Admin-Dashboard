using System.ComponentModel.DataAnnotations;

namespace Portal.Business.Models
{
    #nullable disable
    public class DepartmentVM
    {
        public int Id { get; set; }

        public string Name { get; set; }

		public string Code { get; set; }
    }
}
