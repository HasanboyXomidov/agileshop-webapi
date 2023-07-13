using AgileShop.DataAccess.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.DataAccess.Interfaces.CommonInterfaces
{
    public interface IGetAll<TEntity>
    {
        public Task<IList<TEntity>> GetAllAsync(PaginationParams @params);
    }
}
