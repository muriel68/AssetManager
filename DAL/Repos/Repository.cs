﻿using DAL.Interfaces;
using DAL.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Repos
{
    // TODO: Add more base functionality
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected RandaDBContext DbContext;

        public Repository(IUnitOfWork unitOfWork)
        {
            DbContext = unitOfWork.DbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> query = DbContext.Set<TEntity>();
            return query;
        }

        public TEntity FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            TEntity query = DbContext.Set<TEntity>().Where(predicate).FirstOrDefault();
            return query;
        }

        public TEntity Add(TEntity entity)
        {
            TEntity query = DbContext.Set<TEntity>().Add(entity);
            DbContext.SaveChanges();
            return query;
        }

        public void Delete(TEntity entity)
        {
            TEntity query = DbContext.Set<TEntity>().Remove(entity);
            DbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            TEntity query = DbContext.Set<TEntity>().Find(entity);
            query = entity;
            DbContext.SaveChanges();
        }
    }
}