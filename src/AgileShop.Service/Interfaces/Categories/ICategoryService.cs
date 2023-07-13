using AgileShop.DataAccess.Utils;
using AgileShop.Domain.Entities.Categories;
using AgileShop.Service.Common.Helpers;
using AgileShop.Service.Dtos.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.Service.Interfaces.Categories;

public interface ICategoryService
{
    public Task<bool> CreateAsync(CategoryCreateDtos categoryCreateDtos);
    public Task<bool> DeleteAsync(long categoryId);
    public Task<int> CountAsync();
    public Task<IList<Category>> GetAllAsync(PaginationParams paginationParams);
    public Task<Category> GetByIdAsync(long categoryId);
    public Task<bool>UpadateAsync(long categoryId,CategoryUpdateDtos categoryUpdateDtos);
    
}
