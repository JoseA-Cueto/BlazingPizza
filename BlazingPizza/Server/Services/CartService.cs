// Server/Services/CartService.cs
using BlazingPizza.Server.Data;
using BlazingPizza.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Server.Services
{
    public class CartService
    {
        private readonly PizzaDbContext _dbContext;

        public CartService(PizzaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddToCartAsync(CartItem item)
        {
            // Verifica si la pizza existe en la base de datos
            var pizza = await _dbContext.Pizzas.FindAsync(item.PizzaId);
            if (pizza == null)
            {
                throw new ArgumentException("La pizza no existe.");
            }

            // Busca si el ítem ya está en el carrito
            var existingItem = await _dbContext.CartItems
                .Include(ci => ci.Pizza) // <-- Esto se asegura de que la relación Pizza se cargue
                .FirstOrDefaultAsync(ci => ci.PizzaId == item.PizzaId);

            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                item.Pizza = pizza; // <-- Aquí llenamos el objeto Pizza antes de guardarlo
                _dbContext.CartItems.Add(item);
            }

            await _dbContext.SaveChangesAsync();
        }


        public async Task<List<CartItem>> GetCartItemsAsync()
        {
            return await _dbContext.CartItems
                .Include(ci => ci.Pizza)
                .ToListAsync();
        }

        public async Task RemoveFromCartAsync(int pizzaId)
        {
            var item = await _dbContext.CartItems
                .FirstOrDefaultAsync(ci => ci.PizzaId == pizzaId);

            if (item != null)
            {
                _dbContext.CartItems.Remove(item);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}