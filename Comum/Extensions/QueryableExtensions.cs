using System;
using System.Linq;
using System.Linq.Expressions;

namespace MinhasFinancas.Comum.Extensions {
    public static class QueryableExtensions {
        public static T FindById<T>(this IQueryable<T> query, int id) where T : EntidadeBase {
            return query.FirstOrDefault(e => e.Id == id);
        }

        public static IQueryable<T> GetById<T>(this IQueryable<T> query, int? id) where T : EntidadeBase {
            return query.Where(e => e.Id == id);
        }

        public static IQueryable<T> GetById<T>(this IQueryable<T> query, int id) where T : EntidadeBase {
            return query.Where(e => e.Id == id);
        }

        public static IQueryable<T> GetByIds<T>(this IQueryable<T> query, params int[] ids) where T : EntidadeBase {
            return query.Where(e => ids.Contains(e.Id));
        }

        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool>> predicate) {
            return condition ? query.Where(predicate) : query;
        }

        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool>> predicateTrue, Expression<Func<T, bool>> predicateFalse) {
            return condition ? query.Where(predicateTrue) : query.Where(predicateFalse);
        }

        public static IQueryable<T> OrderByIf<T, TKey>(this IQueryable<T> query, bool condition, Expression<Func<T, TKey>> predicate) {
            return condition ? query.OrderBy(predicate) : query;
        }

        public static IQueryable<T> OrderByDescendingIf<T, TKey>(this IQueryable<T> query, bool condition, Expression<Func<T, TKey>> predicate) {
            return condition ? query.OrderByDescending(predicate) : query;
        }
    }
}
