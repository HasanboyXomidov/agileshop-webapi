using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.Domain.Entities.Discounts
{
    public class Discount : Auditable
    {
        public string Name { get; set; }=String.Empty;
        public string Description { get; set; } = String.Empty;


    }
}
