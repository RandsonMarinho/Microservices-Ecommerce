using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrders()
        {
            var orders = new[]
            {
                new { Id = 1, Product = "Mouse Gamer", Quantity = 2, Price = 199.90 },
                new { Id = 2, Product = "Teclado Mecânico", Quantity = 1, Price = 299.00 }
            };

            return Ok(orders);
        }
    }
}