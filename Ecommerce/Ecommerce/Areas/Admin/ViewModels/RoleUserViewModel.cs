using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Areas.Admin.ViewModels
{
    public class RoleUserViewModel
    {
        [Required(ErrorMessage ="Please Select User.")]
        [Display(Name ="User")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "Please Select Role.")]
        [Display(Name = "Role")]
        public string RoleId { get; set; }
    }
}
