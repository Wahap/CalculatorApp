using Calculator.Data.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using System.Linq;

namespace Calculator.Data.Repos.BO
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext dbContext;
        private readonly DbSet<T> dbSet;

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
         
            dbSet = dbContext.Set<T>();
        }

        public T FindById(int id)
        {
            return dbSet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public void Delete(T entity)
        {
            var entry = dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
                dbSet.Attach(entity);

            dbSet.Remove(entity);
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void BulkInsert(List<T> entities)
        {
        }

        public void Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public int Commit()
        {
            return dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
