// Server/Controllers/CartController.cs
using BlazingPizza.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using BlazingPizza.Server.Services;

namespace BlazingPizza.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly CartService _cartService;

        public CartController(CartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddToCart([FromBody] CartItem item)
        {
            await _cartService.AddToCartAsync(item);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<CartItem>>> GetCart()
        {
            return await _cartService.GetCartItemsAsync();
        }

        [HttpDelete("{pizzaId}")]
        public async Task<IActionResult> RemoveFromCart(int pizzaId)
        {
            await _cartService.RemoveFromCartAsync(pizzaId);
            return Ok();
        }
    }
}
