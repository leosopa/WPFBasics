using SopaAPI.Data;
using SopaAPI.Model;

namespace SopaAPI.Services
{
    public class DepartmentService : BaseService<Department>
    {
        public DepartmentService(IRepository<Department> repository) : base(repository)
        {
        }
    }
}
