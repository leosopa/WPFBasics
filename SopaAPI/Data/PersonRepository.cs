using Microsoft.EntityFrameworkCore;
using SopaAPI.Model;

namespace SopaAPI.Data
{
    public class PersonRepository : BaseRepository<Person>
    {
        public PersonRepository(SoapAPIDbContext context) : base(context)
        {
        }

        public List<Person> GetFullPersonList()
        {
            return _context.Persons.Include(p => p.Details).Include(p => p.Salary).Include(p => p.Position).ThenInclude(p => p.Department).ToList();
        }

    }
}
