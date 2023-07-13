using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.DataAccess.Utils
{
    public class PaginationParams
    {
        public int PageNumber { get; set; } 
        public int PageSize { get; set; }
        
        public PaginationParams(int pagenumber,int pagesize)
        {
            PageNumber = pagenumber;
            PageSize = pagesize;
        }
        public int GetSkipCount()
        {
            return (PageNumber - 1)*PageSize;
        }

    }
}
