using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPersonalTracking.Services
{
    public interface IService<TEntity> where TEntity : class
    {

        TEntity GetById(int id);
        List<TEntity> GetAll();
        bool Save(TEntity entity);
        bool Delete(int id);
        bool Update(TEntity entity);


    }
}
