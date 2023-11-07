using Microsoft.IdentityModel.Tokens;
using SopaAPI.Data;
using SopaAPI.Model;

namespace SopaAPI.Services
{
    public class PersonService : BaseService<Person>
    {

        public PersonService(IRepository<Person> repository) : base(repository)
        {

        }

        public List<Person> GetFullPersonList()
        {
            return ((PersonRepository)_repository).GetFullPersonList();

        }

    }
}
