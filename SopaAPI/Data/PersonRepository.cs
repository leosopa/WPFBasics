using SopaAPI.Model;

namespace SopaAPI.Data
{
    public class PersonRepository : BaseRepository<Person>
    {
        public PersonRepository(SoapAPIDbContext context) : base(context)
        {
        }
    
    }
}
