using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoTask.Context.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context dbContext;

        public UnitOfWork(Context dbContext)
        {
            this.dbContext = dbContext;
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public DbSet<TEntity> GetEntitySet<TEntity>() where TEntity : class
        {
            return dbContext.Set<TEntity>();
        }
    }

    public interface IUnitOfWork
    {
        void SaveChanges();
        DbSet<TEntity> GetEntitySet<TEntity>() where TEntity : class;
    }
}