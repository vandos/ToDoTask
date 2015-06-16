using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoTask.Context.Repository
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Delete(T entity);
        void Delete(int id);
        void Update(T entity);
        void Save();
        T FetchById(int id);
        IQueryable<T> Fetch();
    }
}