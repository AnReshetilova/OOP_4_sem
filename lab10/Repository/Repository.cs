using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10.Repository
{
    class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=lab10;Integrated Security=True";
        private Entities context;
        public Repository()
        {
            context = Entities.GetContext();
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<TEntity> FindAll()
        {
            return context.Set<TEntity>().AsEnumerable();
        }

        public TEntity FindById(params object[] values)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
        }
    }
}
