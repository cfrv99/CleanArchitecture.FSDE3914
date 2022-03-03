using FirstApi.Domain.Commons.EntityBase;
using FirstApi.Domain.Commons.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Domain.Commons.Extensions
{
    public static class LinqExtensions
    {
        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool>> predicate) where T : IEntity
        {
            if (condition)
            {
                query = query.Where(predicate);
            }
            return query;
        }

        public static IQueryable<T> PageBy<T>(this IQueryable<T> query, IRequestPaging request)
        {
            return query.Skip((request.CurrentPage - 1) * request.Limit).Take(request.Limit);
        }
    }
}
