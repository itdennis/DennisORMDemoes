using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProductsApp.Default;

namespace ProductsApp
{
    public class DbContextRepository<T> : IRepository<T> where T : class
    {
        private readonly Container container;

        public DbContextRepository(Container container)
        {
            this.container = container;
        }

        public T Add(T entity)
        {
            container.AddObject("", entity);
            var res = container.SaveChanges();
            return entity;
        }

        public bool Any(Expression<Func<T, bool>> condition = null)
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<T, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(object key)
        {
            throw new NotImplementedException();
        }

        public int Delete(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public int Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
