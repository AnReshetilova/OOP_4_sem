using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Repository
{
    public interface IRepository<TEntity>
    {
        TEntity FindById(params object[] values);
        IEnumerable<TEntity> FindAll();
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
