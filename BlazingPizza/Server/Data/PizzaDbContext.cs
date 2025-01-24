using Microsoft.EntityFrameworkCore;
using BlazingPizza.Server.Models;
using System.Collections.Generic;

namespace BlazingPizza.Server.Data
{
    public class PizzaDbContext : DbContext
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options) { }

        public DbSet<Pizza> Pizzas { get; set; }
    }
}
