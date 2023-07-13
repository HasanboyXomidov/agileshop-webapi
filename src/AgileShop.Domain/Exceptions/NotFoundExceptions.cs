using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.Domain.Exceptions
{
    public class NotFoundExceptions : Exception
    {
        public HttpStatusCode StatusCode { get; set; } = HttpStatusCode.NotFound;
        public string TitleMessage { get; set; } = string.Empty;

    }   
}
