using SopaAPI.Data;
using SopaAPI.Model;

namespace SopaAPI.Services
{
    public class PositionService : BaseService<Position>
    {
        public PositionService(IRepository<Position> repository) : base(repository)
        {
        }
    }
}
