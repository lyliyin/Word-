using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CastleDemo.Domain.IRepository;
using CastleDemo.Domain.Models;
using CastleDemo.Domain;

namespace CastleDemo.DataAccess.RepositoryImpl
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private castledemoContext context = Factories.Repository<castledemoContext>();

        public IEnumerable<T> Find(Expression<Func<T, bool>> condition, Expression<Func<T,object>> order = null)
        {
            if (order == null)
            {
                return context.Set<T>().Where(condition);
            }

            return context.Set<T>().Where(condition).OrderByDescending(order);
        }
    }
}
