using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Models
{
    [Table("Cart")]
    public class Cart
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
        public List<CartItem> CartItems{ get; set; }
    }
}
