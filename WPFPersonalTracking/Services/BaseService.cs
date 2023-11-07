using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPersonalTracking.Model;
using WPFPersonalTracking.Repository;

namespace WPFPersonalTracking.Services
{
    public class BaseService<TEntity> : IService<TEntity> where TEntity : BaseModel
    {

        protected PersonalTrackingContext _dbContext;

        public BaseService(PersonalTrackingContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Delete(int id)
        {
            var entity = _dbContext.Set<TEntity>().FirstOrDefault(e => e.Id == id);

            if (entity == null) 
                return false;
            else
            {
                _dbContext.Set<TEntity>().Remove(entity);
                _dbContext.SaveChanges();
                return true;
            }
        }

        public List<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>().FirstOrDefault(e => e.Id == id);
        }

        public bool Save(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();

            if (entity.Id != 0)
                return true;
            else
                return false;   
        }

        public bool Update(TEntity entity)
        {
            var oldEntity = _dbContext.Set<TEntity>().FirstOrDefault(e => e.Id == entity.Id);

            if (oldEntity != null)
            {
                _dbContext.Set<TEntity>().Entry(entity).State = EntityState.Modified;
                _dbContext.SaveChanges();

                return true;
            }
            else
                return false;
        }
    }
}
