using System.Linq;

namespace Pagination.Paging
{
    public static class PagingExtension
    {
        public static IQueryable<T> Paging<T>(this IQueryable<T> queryable, BasePaging basePaging)
        {
            return queryable.Skip(basePaging.SkipEntity).Take(basePaging.TakeEntity);
        }
    }
}
