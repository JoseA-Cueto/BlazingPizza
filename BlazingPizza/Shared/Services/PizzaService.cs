using BlazingPizza.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingPizza.Shared
{
    public static class PizzaService
    {
        public static List<Pizza> GetPizzas()
        {
            return new List<Pizza>
            {
                new Pizza
                {
                    Id = 1,
                    Name = "Margherita",
                    Description = "Classic cheese and tomato pizza.",
                    Price = 8.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new Pizza
                {
                    Id = 2,
                    Name = "Pepperoni",
                    Description = "Loaded with pepperoni and cheese.",
                    Price = 9.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new Pizza
                {
                    Id = 3,
                    Name = "Hawaiian",
                    Description = "Pineapple, ham, and cheese – the classic debate.",
                    Price = 10.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new Pizza
                {
                    Id = 4,
                    Name = "Veggie",
                    Description = "A healthy choice with fresh veggies.",
                    Price = 8.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                }
            };
        }
    }
}

