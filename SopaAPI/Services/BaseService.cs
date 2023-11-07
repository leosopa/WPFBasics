using SopaAPI.Data;
using SopaAPI.Model;

namespace SopaAPI.Services
{
    public class BaseService<TEntity> where TEntity : class
    {

        protected readonly IRepository<TEntity> _repository;

        public BaseService(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public List<TEntity> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public bool Save(TEntity obj)
        {
            return _repository.Save(obj);
        }

        public bool Update(TEntity obj)
        {
            return _repository.Update(obj);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

    }
}
