using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace SmartSchool.WebAPI.Helpers
{
    public static class Extensions
    {
        public static void AddPagination(
            this HttpResponse response,
            int currentPage,
            int totalPages,
            int itemsPerPage,
            int totalItems
        )
        {
            var paginationHeader = new PaginationHeader(currentPage, totalPages, itemsPerPage, totalItems);
            response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader));
            response.Headers.Add("Access-Control-Exposed-Header", "Pagination");
        }
    }
}