﻿using AgileShop.DataAccess.Interfaces.CommonInterfaces;
using AgileShop.Domain.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.DataAccess.Interfaces.Categories
{
    public interface ICategoryRepository:IRepository<Category,Category>,
        IGetAll<Category>
    {

    }
}
