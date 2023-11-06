using SopaAPI.Model;

namespace SopaAPI.Data
{
    public class PersonDetailRepository : BaseRepository<PersonDetails>
    {
        public PersonDetailRepository(SoapAPIDbContext context) : base(context)
        {
        }
    
    }
}
