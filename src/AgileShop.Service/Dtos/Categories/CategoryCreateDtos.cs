using AgileShop.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.Service.Dtos.Categories;

public class CategoryCreateDtos 
{
    public string name { get; set; }= string.Empty;
    public string description { get; set; } = string.Empty;
    public IFormFile image { get; set; } = default!;

}
