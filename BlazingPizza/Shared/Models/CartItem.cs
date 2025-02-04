using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingPizza.Shared.Models
{
    public class CartItem
    {
        public int PizzaId { get; set; } // Relación con la Pizza
        public string PizzaName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1; // Default: 1 unidad
    }
}
