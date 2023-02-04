namespace Pagination.Paging
{
    public class BasePaging
    {
        public BasePaging()
        {
            Page = 1;
            TakeEntity = 10;
            HowManyPagesShowAfterBefore = 4;
        }

        public int Page { get; set; }

        public int AllEntitiesCount { get; set; }

        public int TakeEntity { get; set; }

        public int SkipEntity { get; set; }

        public int HowManyPagesShowAfterBefore { get; set; }

        public int StartPage { get; set; }

        public int EndPage { get; set; }

        public int PageCount { get; set; }

        public BasePaging GetCurrentPaging()
        {
            return this;
        }
    }
}
