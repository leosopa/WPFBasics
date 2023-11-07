using SopaAPI.Model;

namespace SopaAPI.Data
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly SoapAPIDbContext _context;

        public BaseRepository(SoapAPIDbContext context)
        {
            _context = context;
        }

        public bool Delete(int id)
        {
            var entity = _context.Set<TEntity>().FirstOrDefault(e => e.Id == id);

            if (entity != null)
            {
                _context.Set<TEntity>().Remove(entity);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().FirstOrDefault(e => e.Id == id);
        }

        public bool Save(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();

            if (entity.Id != 0) 
                return true;
            return false;
        }

        public bool Update(TEntity entity)
        {
            var existingEntity = _context.Set<TEntity>().FirstOrDefault(e => e.Id == entity.Id);

            if (existingEntity != null)
            {
                foreach (var prop in typeof(TEntity).GetProperties())
                {
                    if (prop.Name != "Id")
                        prop.SetValue(existingEntity, prop.GetValue(entity));
                }

                _context.SaveChanges(true);
                return true;
            }

            return false;
        }
    }
}
