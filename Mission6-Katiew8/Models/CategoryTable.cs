using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission6_Katiew8.Models
{
    public class CategoryTable
    {
  
        [Key]
        [Required]
        public int CategoryId { get; set; }
        public string Category { get; set; }

    }
}
