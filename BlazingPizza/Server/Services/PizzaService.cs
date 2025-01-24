using BlazingPizza.Server.Data;
using BlazingPizza.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Server.Services
{
    public class PizzaService
    {
        private readonly PizzaDbContext _dbContext;

        public PizzaService(PizzaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Pizza>> GetPizzasAsync()
        {
            return await _dbContext.Pizzas.ToListAsync();
        }
    }
}


