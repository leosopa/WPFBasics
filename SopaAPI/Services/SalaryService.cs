using SopaAPI.Data;
using SopaAPI.Model;

namespace SopaAPI.Services
{
    public class SalaryService : BaseService<Salary>
    {
        public SalaryService(IRepository<Salary> repository) : base(repository)
        {
        }
    }
}
