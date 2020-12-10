namespace SmartSchool.WebAPI.Helpers
{
    public class PageParams
    {
        public const int maxPageSize = 50;

        public int PageNumber { get; set; }

        private int pageSize = 10;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > maxPageSize) ? maxPageSize : value; }
        }

    }
}