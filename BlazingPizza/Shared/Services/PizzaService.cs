using BlazingPizza.Shared.Models;

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
                    ImageUrl = "/images/pizzas/margherita.jpg"
                },
                new Pizza
                {
                    Id = 2,
                    Name = "Pepperoni",
                    Description = "Loaded with pepperoni and cheese.",
                    Price = 9.99m,
                    ImageUrl = "/images/pizzas/pepperoni.jpg"
                },
                new Pizza
                {
                    Id = 3,
                    Name = "Hawaiian",
                    Description = "Pineapple, ham, and cheese – the classic debate.",
                    Price = 10.99m,
                    ImageUrl = "/images/pizzas/hawaiian.jpg"
                },
                new Pizza
                {
                    Id = 4,
                    Name = "Veggie",
                    Description = "A healthy choice with fresh veggies.",
                    Price = 7.99m,
                    ImageUrl = "/images/pizzas/veggie.jpg"
                }
            };
        }
    }
}


