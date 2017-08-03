using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.Data.Repository.Interfaces
{
    public interface IRepository<T> : IDisposable
    {
        T FindById(int id);
        IQueryable<T> GetAll();
        void Delete(T entity);
        void Add(T entity);
        void BulkInsert(List<T> entities);
        void Update(T entity);

        int Commit();
    }
}
