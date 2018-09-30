using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repos
{
    public class SiteRepository : ISite
    {
        public IRandaDBContext _context = new RandaDBContext();
        public IUnitOfWork _uow = new UnitOfWork();

        public SiteRepository(IRandaDBContext context, IUnitOfWork uow)
        {
            this._context = context;
            this._uow = uow;
        }
        public Site Add(Site entity)
        {
            return _uow.DbContext.Sites.Add(entity);
        }

        public void Delete(Site entity)
        {
            _uow.DbContext.Sites.Remove(entity);
        }


        public IQueryable<Site> FindBy(Expression<Func<Site, bool>> predicate)
        {
            return _uow.DbContext.Sites.Where(predicate);
        }

        public IQueryable<Site> GetAll()
        {
            return _uow.DbContext.Sites;
        }

        public void Update(Site entity)
        {
            Site query = _context.Sites.FirstOrDefault(a => a.SiteId == entity.SiteId);
            query = entity;
        }
    }
}
