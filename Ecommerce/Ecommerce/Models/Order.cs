using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetails>();
        }
        public int Id { get; set; }
        [Display(Name = "Order")]
        public string OrderNo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^(?:\+88|01)?\d{11}$",ErrorMessage ="Invalid number.")]
        [Display(Name ="Phone No")]
        public string PhoneNo { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Invalid email address.")]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
    
        public DateTime OrderDate { get; set; }
        public virtual List<OrderDetails> OrderDetails { get; set; }
    }
}
