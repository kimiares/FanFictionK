using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFK.Services
{
    public class Pagination
    {
        public int PageNumber { get; set; }
        public int TotalPages { get; set; }

        public Pagination(int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageNumber > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageNumber < TotalPages);
            }
        }
    }
}
