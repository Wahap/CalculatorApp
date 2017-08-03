using Calculator.Data.Repository.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Calculator.Data.Repository.BO
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext dbContext;
        private readonly DbSet<T> dbSet;

        public Repository(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbContext.Configuration.LazyLoadingEnabled = false;
            this.dbContext.Configuration.AutoDetectChangesEnabled = false;
            this.dbContext.Configuration.ValidateOnSaveEnabled = false;
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
