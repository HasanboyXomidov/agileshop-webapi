using AgileShop.DataAccess.Interfaces.Categories;
using AgileShop.DataAccess.Utils;
using AgileShop.Service.Dtos.Categories;
using AgileShop.Service.Interfaces.Categories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace AgileShop.WebApi.Controllers;

[Route("api/categories")]
[ApiController]
public class CategoriesControllers : ControllerBase
{
    private readonly ICategoryService _repository;
    private readonly int maxPageSize = 30;
    public CategoriesControllers(ICategoryService service)
    {
        this._repository = service;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllAsync([FromQuery] int page=1)
        =>Ok(await _repository.GetAllAsync(new PaginationParams(page,maxPageSize)));
    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromForm] CategoryCreateDtos dtos)
        =>Ok(await _repository.CreateAsync(dtos));
    [HttpDelete("{categoryId}")]
    public async Task<IActionResult> DeleteAsync(long categoryId) =>
        Ok(await _repository.DeleteAsync(categoryId));
}
