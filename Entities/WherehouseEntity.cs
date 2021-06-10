using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WherehouseEntity
    {
        [Key]
        [StringLength(10)]
        public string WherehouseId { get; set; }
        [Required]
        [StringLength(100)]
        public string WherehouseName { get; set; }
        [Required]
        [StringLength(100)]
        public string WherehouseAddress { get; set; }
    }
}
