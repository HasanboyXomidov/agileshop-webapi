using AgileShop.DataAccess.Interfaces.Categories;
using AgileShop.DataAccess.Utils;
using AgileShop.Domain.Entities.Categories;
using AgileShop.Domain.Exceptions.Categories;
using AgileShop.Domain.Exceptions.Files;
using AgileShop.Service.Common.Helpers;
using AgileShop.Service.Dtos.Categories;
using AgileShop.Service.Interfaces.Categories;
using AgileShop.Service.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.Service.Services.CategoryService;

public class CategoryServices : ICategoryService
{
    private readonly ICategoryRepository _repository;
    private readonly IFileService _fileService;
    public CategoryServices(ICategoryRepository categoryRepository,IFileService fileServiceRepository)
    {
        this._repository = categoryRepository;
        this._fileService = fileServiceRepository;
    }
    public  async Task<bool> CreateAsync(CategoryCreateDtos categoryCreateDtos)
    {
        string imagePath = await _fileService.UploadImageAsync(categoryCreateDtos.image);
        Category category = new Category()
        {
            image_path = imagePath,
            name = categoryCreateDtos.name,
            description = categoryCreateDtos.description,
            created_at = TimeHelpers.GetDateTime(),
            updated_at = TimeHelpers.GetDateTime()
        };
        var result = await _repository.CreateAsync(category);
        return result>0;
    }

    public async Task<bool> DeleteAsync(long categoryId)
    {
        var category = await _repository.GetByIdAsync(categoryId);
        if (category == null) { throw new CategoryNotFounException(); }

        var result = await _fileService.DeleteImageAsync(category.image_path);
        if (result == false) throw new ImageNotFoundException();

        var dbresult = await _repository.DeleteAsync(categoryId);
        return dbresult > 0;
    }

    public Task<int> CountAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<IList<Category>> GetAllAsync(PaginationParams paginationParams)
    {        
        var categories = await _repository.GetAllAsync(paginationParams);
        return categories;
    }

    public Task<Category> GetByIdAsync(long categoryId)
    {
        throw new CategoryNotFounException();
    }

    public async Task<bool> UpadateAsync(long categoryId, CategoryUpdateDtos categoryUpdateDtos)
    {
        var category=await _repository.GetByIdAsync(categoryId);
        if(category == null) {throw new CategoryNotFounException(); }
        //parse new items to category
        category.name = categoryUpdateDtos.name;
        category.description = categoryUpdateDtos.description;
        if(categoryUpdateDtos.Image is not null)
        {
            //delete old image
            var deleteresult = await _fileService.DeleteImageAsync(category.image_path);
            if (deleteresult == false)throw new ImageNotFoundException();

            //upload image
            var uploadImage = await _fileService.UploadImageAsync(categoryUpdateDtos.Image);
            category.image_path = uploadImage;
            
        }
        //else category old image have to save 

        category.updated_at = TimeHelpers.GetDateTime();

        var dbResult = await _repository.UpdateAsync(categoryId, category);
        return dbResult > 0;

    }
}