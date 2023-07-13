using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileShop.Domain.Entities
{
    public abstract class Human : Auditable
    {
        [MaxLength(50)]
        public string firstname { get; set; } = string.Empty;
        [MaxLength(50)]
        public string lastname { get; set; } = string.Empty;
        [MaxLength(9)]
        public string passportSerialNumber { get; set; } = string.Empty;
        public bool isMale { get; set; }
        public DateOnly dateBirth { get; set; }
        public string country { get; set; }= string.Empty;
        public string region { get ; set; } = string.Empty;
        public string imgaePath { get; set; } = string.Empty;

    }
}
