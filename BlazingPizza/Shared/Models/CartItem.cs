using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingPizza.Shared.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }    
        public virtual Pizza? Pizza { get; set; } 
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
