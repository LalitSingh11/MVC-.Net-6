using System.Linq.Expressions;
using System.Reflection;

namespace BHI.SalesArchitect.Core.Extensions
{
    public static class LinqExtensions
    {

        public static IEnumerable<TEntity> OrderBy<TEntity>(this IEnumerable<TEntity> source, string orderByProperty,
                            bool desc)
        {
            string command = desc ? "OrderByDescending" : "OrderBy";
            var type = typeof(TEntity);
            var property = type.GetProperty(orderByProperty);
            var parameter = Expression.Parameter(type, "p");
            var propertyAccess = Expression.MakeMemberAccess(parameter, property);
            var orderByExpression = Expression.Lambda(propertyAccess, parameter);
            var resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { type, property.PropertyType },
                                          source.AsQueryable().Expression, Expression.Quote(orderByExpression));
            return source.AsQueryable().Provider.CreateQuery<TEntity>(resultExpression);
        }


        public static IEnumerable<T> OrderByDynamic<T>(this IEnumerable<T> source, string property, bool desc)
        {
            if (desc)
            {
                return ApplyOrder<T>(source, property, "OrderByDescending");
            }
            else
            {
                return ApplyOrder<T>(source, property, "OrderBy");
            }
        }
        public static IEnumerable<T> ThenByDynamic<T>(this IEnumerable<T> source, string property, bool desc)
        {
            if (desc)
            {
                return ApplyOrder<T>(source, property, "ThenByDescending");
            }
            else
            {
                return ApplyOrder<T>(source, property, "ThenBy");
            }
        }

        public static IEnumerable<T> ApplyOrder<T>(IEnumerable<T> source, string property, string methodName)
        {
            string[] props = property.Split('.');
            Type type = typeof(T);
            ParameterExpression arg = Expression.Parameter(type, "x");
            Expression expr = arg;
            foreach (string prop in props)
            {
                PropertyInfo pi = type.GetProperty(prop);
                expr = Expression.Property(expr, pi);
                type = pi.PropertyType;
            }
            Type delegateType = typeof(Func<,>).MakeGenericType(typeof(T), type);
            LambdaExpression lambda = Expression.Lambda(delegateType, expr, arg);

            var result = typeof(Queryable).GetMethods().Single(
                    method => method.Name == methodName
                            && method.IsGenericMethodDefinition
                            && method.GetGenericArguments().Length == 2
                            && method.GetParameters().Length == 2)
                    .MakeGenericMethod(typeof(T), type)
                    .Invoke(null, new object[] { source.AsQueryable(), lambda });
            return (IEnumerable<T>)result;
        }
    }
}
