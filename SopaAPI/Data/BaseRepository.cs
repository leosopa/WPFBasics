using SopaAPI.Model;

namespace SopaAPI.Data
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly SoapAPIDbContext _context;

        public BaseRepository(SoapAPIDbContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var entity = _context.Set<TEntity>().Where(e => e.Id == id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().FirstOrDefault(e => e.Id == id);
        }

        public void Save(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);        
        }
    }
}
