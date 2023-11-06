using SopaAPI.Data;
using SopaAPI.Model;

namespace SopaAPI.Services
{
    public class PersonDetailsService : BaseService<PersonDetails>
    {
        public PersonDetailsService(IRepository<PersonDetails> repository) : base(repository)
        {
        }
    }
}
