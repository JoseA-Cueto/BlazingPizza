using BlazingPizza.Server.Services;
using BlazingPizza.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazingPizza.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaService _pizzaService;

        public PizzaController(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Pizza>>> GetPizzas()
        {
            var pizzas = await _pizzaService.GetPizzasAsync();
            return Ok(pizzas);
        }
    }
}

