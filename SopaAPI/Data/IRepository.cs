namespace SopaAPI.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        bool Save(TEntity entity);
        bool Delete(int id);
        bool Update(TEntity entity);
    }
}
