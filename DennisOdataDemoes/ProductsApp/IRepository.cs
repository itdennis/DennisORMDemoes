using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProductsApp.DennisOdataDemoes;
using ProductsApp.DennisOdataDemoes.Models;

namespace ProductsApp
{
    public interface IRepository<T> where T : class
    {
        T Add(T entity);

        int Update(T entity);

        int Delete(T entity);

        int Delete(object key);

        int Delete(IEnumerable<T> entities);

        int Count(Expression<Func<T, bool>> condition);

        bool Any(Expression<Func<T, bool>> condition = null);
    }
}
