using System;

namespace Pagination.Paging
{
    public class Pager
    {
        public static BasePaging Build(int page, int allEntitiesCount, int takeEntity, int howManyPagesShowAfterBefore)
        {
            var pageCount = (int)Math.Ceiling(allEntitiesCount / (double)takeEntity);
            return new BasePaging
            {
                AllEntitiesCount = allEntitiesCount,
                Page = page,
                HowManyPagesShowAfterBefore = howManyPagesShowAfterBefore,
                TakeEntity = takeEntity,
                SkipEntity = takeEntity * (page - 1),
                PageCount = pageCount,
                StartPage = page - howManyPagesShowAfterBefore < 0 ? 1 : page - howManyPagesShowAfterBefore,
                EndPage = page + howManyPagesShowAfterBefore > pageCount ? pageCount : page + howManyPagesShowAfterBefore
            };
        }
    }
}
