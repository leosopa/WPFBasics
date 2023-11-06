using SopaAPI.Data;
using SopaAPI.Model;

namespace SopaAPI.Services
{
    public class BaseService<TEntity> where TEntity : class
    {

        private readonly IRepository<TEntity> _repository;

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

        public void Save(TEntity obj)
        {
            _repository.Save(obj);
        }

    }
}
