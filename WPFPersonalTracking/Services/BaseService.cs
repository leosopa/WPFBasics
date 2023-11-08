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

        protected PersonalTrackingContext DbContext { get; set; }

        public BaseService()
        {
            DbContext = new PersonalTrackingContext();
        }

        public bool Delete(int id)
        {
            var entity = DbContext.Set<TEntity>().FirstOrDefault(e => e.Id == id);

            if (entity == null) 
                return false;
            else
            {
                DbContext.Set<TEntity>().Remove(entity);
                DbContext.SaveChanges();
                return true;
            }
        }

        public List<TEntity> GetAll()
        {
            return DbContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return DbContext.Set<TEntity>().FirstOrDefault(e => e.Id == id);
        }

        public bool Save(TEntity entity)
        {
            DbContext.Set<TEntity>().Add(entity);
            DbContext.SaveChanges();

            if (entity.Id != 0)
                return true;
            else
                return false;   
        }

        public bool Update(TEntity entity)
        {
            var oldEntity = DbContext.Set<TEntity>().FirstOrDefault(e => e.Id == entity.Id);

            if (oldEntity != null)
            {
                DbContext.Set<TEntity>().Entry(entity).State = EntityState.Modified;
                DbContext.SaveChanges();

                return true;
            }
            else
                return false;
        }
    }
}
