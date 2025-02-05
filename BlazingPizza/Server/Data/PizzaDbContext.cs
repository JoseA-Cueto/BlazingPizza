using Microsoft.EntityFrameworkCore;
using BlazingPizza.Shared.Models;
using System.Collections.Generic;

namespace BlazingPizza.Server.Data
{
    public class PizzaDbContext : DbContext
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options) { }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Cart> Carts { get; set; } 
        public DbSet<CartItem> CartItems { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Pizza) 
                .WithMany() 
                .HasForeignKey(ci => ci.PizzaId);
          
            modelBuilder.Entity<CartItem>()
                .Ignore(ci => ci.Pizza);
        }
    }
}
