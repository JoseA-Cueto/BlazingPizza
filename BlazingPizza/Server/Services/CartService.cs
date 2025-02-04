// BlazingPizza.Server/Services/CartService.cs
using BlazingPizza.Shared.Models;
using System.Collections.Generic;

namespace BlazingPizza.Server.Services
{
    public class CartService
    {
        public Cart CurrentCart { get; private set; } = new Cart();

        // Añadir pizza al carrito
        public void AddToCart(Pizza pizza, int quantity = 1)
        {
            var existingItem = CurrentCart.Items.FirstOrDefault(item => item.PizzaId == pizza.Id);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity; 
            }
            else
            {
                CurrentCart.Items.Add(new CartItem
                {
                    PizzaId = pizza.Id,
                    PizzaName = pizza.Name,
                    Price = pizza.Price,
                    Quantity = quantity
                });
            }
        }

        // Eliminar pizza del carrito
        public void RemoveFromCart(int pizzaId)
        {
            var item = CurrentCart.Items.FirstOrDefault(item => item.PizzaId == pizzaId);
            if (item != null)
            {
                CurrentCart.Items.Remove(item);
            }
        }

        // Vaciar carrito
        public void ClearCart()
        {
            CurrentCart.Items.Clear();
        }
    }
}
