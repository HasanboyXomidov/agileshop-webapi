using AgileShop.DataAccess.Interfaces.CommonInterfaces;
using AgileShop.Domain.Entities.Discounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.DataAccess.Interfaces
{
    public interface IDiscountRepository : IRepository<Discount , Discount>,
        IGetAll<Discount>
    {
    }
}
