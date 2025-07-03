using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Services;

namespace OnlinePharmacyAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly Unity _unity;

        public CartController(Unity unity)
        {
            _unity = unity;
        }

        // POST: api/Cart
        [HttpPost]
        public IActionResult AddToCart([FromBody] CartDTO cartDto)
        {
            var result = _unity.CartService.AddToCart(cartDto);
            if (result)
                return Ok(new { message = "Item added to cart." });
            else
                return BadRequest(new { message = "Failed to add item to cart." });
        }

        // Optional: GET carts for a user
        [HttpGet("{userId}")]
        public IActionResult GetCartForUser(int userId)
        {
            var cartItems = _unity.CartService.GetCartByUserId(userId);
            return Ok(cartItems);
        }

        // Optional: DELETE item from cart
        [HttpDelete("{cartId}")]
        public IActionResult DeleteCartItem(int cartId)
        {
            bool deleted = _unity.CartService.DeleteCartItem(cartId);
            if (!deleted)
                return NotFound(new { message = "Cart item not found." });

            return Ok(new { message = "Cart item removed." });
        }
        [HttpGet("summary/{userId}")]
        public IActionResult GetCartSummary(int userId)
        {
            var summary = _unity.CartService.GetCartSummaryWithDiscount(userId);
            return Ok(summary);
        }
        [HttpPut("UpdateQuantity")]
        public IActionResult UpdateQuantity([FromBody] CartDTO dto)
        {
            var updated = _unity.CartService.UpdateCartQuantity(dto);
            if (!updated)
                return NotFound("Failed to update quantity.");

            return Ok();
        }
        [HttpPost("checkout/{userId}")]
        public IActionResult Checkout(int userId)
        {
            var result = _unity.CartService.ProcessCheckout(userId);
            if (!result.Success)
                return BadRequest(new { message = result.Message });

            return Ok(new { paymentUrl = $"/Payment/Index?amount={result.FinalAmount}" });
        }





    }
}
