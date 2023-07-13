using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.Domain.Entities.Categories;

public class Category : Auditable
{
    [MaxLength(50)]
    public string name { get; set; }=string.Empty;
    public string description { get; set; }= string.Empty;
    public string image_path { get; set; } = string.Empty;


}
