using SopaAPI.Model;

namespace SopaAPI.Data
{
    public class PositionRepository : BaseRepository<Position>
    {
        public PositionRepository(SoapAPIDbContext context) : base(context)
        {
        }
    }
}
