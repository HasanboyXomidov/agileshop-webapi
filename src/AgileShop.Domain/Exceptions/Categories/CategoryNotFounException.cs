using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.Domain.Exceptions.Categories
{
    public class CategoryNotFounException:NotFoundExceptions
    {
        public CategoryNotFounException()
        {
            this.TitleMessage = "Category Not Found";
        }

    }
}
