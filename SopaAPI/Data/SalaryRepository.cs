using SopaAPI.Model;

namespace SopaAPI.Data
{
    public class SalaryRepository : BaseRepository<Salary>
    {
        public SalaryRepository(SoapAPIDbContext context) : base(context)
        {
        }
    
    }
}
