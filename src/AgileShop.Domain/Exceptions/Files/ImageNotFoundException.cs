using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.Domain.Exceptions.Files
{
    public class ImageNotFoundException :NotFoundExceptions
    {
        public ImageNotFoundException()
        {
            this.TitleMessage = "Image Not Found";
        }
    }
}
