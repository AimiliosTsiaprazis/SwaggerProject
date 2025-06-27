using Microsoft.AspNetCore.Mvc;
using SwaggerProject.Modells;

namespace SwaggerProject.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            return _orderService.GetOrders();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Order order)
        {
            await _orderService.AddAsync(order);
            return CreatedAtAction(nameof(Get), new { id = order.Id }, order);
        }
    }
}