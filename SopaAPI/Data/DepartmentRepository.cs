using SopaAPI.Model;

namespace SopaAPI.Data
{
    public class DepartmentRepository : BaseRepository<Department>
    {
        public DepartmentRepository(SoapAPIDbContext context) : base(context)
        {
        }

    }
}
