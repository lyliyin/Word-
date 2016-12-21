using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CastleDemo.Domain.IRepository
{
    public interface IRepository<T>  where T : class
    {
        /// <summary>
        /// 查询  
        /// </summary>
        /// <param name="condition">查询条件</param>
        /// <param name="order">排序条件</param>
        /// <returns></returns>
        IEnumerable<T> Find(Expression<Func<T, bool>> condition, Expression<Func<T, object>> order = null);
    }
}
