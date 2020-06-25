using NHD.EntityFramework.DataContext;
using NHD.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NHD.Repository
{
    public class QLSachRepository<T> : IQLSachRepository<T> where T : class
    {
        private QLSachDbContext dbContext;
        public QLSachRepository()
        {
            dbContext = new QLSachDbContext();
        }

        public T Add(T entity)
        {
            var result = dbContext.Set<T>().Add(entity);
            dbContext.SaveChanges();
            return result;
        }

        public void Delete(object id)
        {
            var existing = dbContext.Set<T>().Find(id);
            if (existing != null)
            {
                dbContext.Set<T>().Remove(existing);
                dbContext.SaveChanges();
            }
        }

        public T GetByCondition(Expression<Func<T, bool>> expression)
        {
            return dbContext.Set<T>().FirstOrDefault(expression);
        }

        public T GetByID(object id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetByWhere(Expression<Func<T, bool>> expression)
        {
            return dbContext.Set<T>().Where(expression);
        }

        public T Update(T entity)
        {
            var result = dbContext.Set<T>().Attach(entity);
            dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            dbContext.SaveChanges();
            return result;

        }
    }
}
