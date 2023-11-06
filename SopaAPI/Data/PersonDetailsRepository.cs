using SopaAPI.Model;

namespace SopaAPI.Data
{
    public class PersonDetailsRepository : BaseRepository<PersonDetails>
    {
        public PersonDetailsRepository(SoapAPIDbContext context) : base(context)
        {
        }
    
    }
}
