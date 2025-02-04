using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Shared/Models/Cart.cs
namespace BlazingPizza.Shared.Models
{
    public class Cart
    {
        public int Id { get; set; } 
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public decimal TotalPrice => Items.Sum(item => item.Pizza.Price * item.Quantity);
    }
}