

using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repos
{
    public class UnitOfWork : IUnitOfWork
    {
        protected string ConnectionString;
        private RandaDBContext context;

        //public UnitOfWork(string connectionString)
        //{
        //    this.ConnectionString = connectionString;
        //}

        public RandaDBContext DbContext
        {
            get
            {
                if (context == null)
                {
                    context = new RandaDBContext();
                }
                return context;
            }
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                    context = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
    }
}
