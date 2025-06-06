using Microsoft.AspNetCore.Mvc;
using SwaggerProject.Modells;

namespace SwaggerProject.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public ActionResult<List<Customer>> Get()
        {
            return _customerService.GetCustomers();
        }
        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            _customerService.Add(customer);
            return CreatedAtAction(nameof(Get), customer);
        }
    }
}