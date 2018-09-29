using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repos
{
    public class AssetRepository : IAssetRepository
    {
        public IRandaDBContext _context = new RandaDBContext();

        public Asset Add(Asset entity)
        {
            return _context.Assets.Add(entity);
        }

        public void Delete(Asset entity)
        {
            _context.Assets.Remove(entity);
        }


        public IQueryable<Asset> FindBy(Expression<Func<Asset, bool>> predicate)
        {
            return _context.Assets.Where(predicate);
        }

        public IQueryable<Asset> GetAll()
        {
            return _context.Assets;
        }

        public void Update(Asset entity)
        {
            Asset query = _context.Assets.FirstOrDefault(a => a.AssetID == entity.AssetID);
            query = entity;
        }
    }
}
