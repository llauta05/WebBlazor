﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(10)]
        public string StorageId { get; set; }
        [Required]
        public DateTime LastUpdate { get; set; }
        [Required]
        public int PartialQuantity { get; set; }
    }
}
