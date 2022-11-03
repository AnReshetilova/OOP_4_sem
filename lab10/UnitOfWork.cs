
using lab10.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class UnitOfWork : IDisposable
    {
        private ClothesRepository adressRepository;
        private Entities context;

        public UnitOfWork()
        {
            context = new Entities();
        }

        public ClothesRepository AdressRepository
        { 
            get 
            { 
                if (adressRepository == null)
                {
                    adressRepository = new ClothesRepository();
                }
                return adressRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
