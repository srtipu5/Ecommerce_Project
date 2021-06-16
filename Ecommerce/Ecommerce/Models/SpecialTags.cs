using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class SpecialTags
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tag Name")]
        public string SpecialTag { get; set; }
    }
}
