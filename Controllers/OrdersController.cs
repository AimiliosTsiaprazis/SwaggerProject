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
        public IActionResult Add(Order order)
        {
            _orderService.Add(order);
            return CreatedAtAction(nameof(Get), order);
        }
    }
}