using Microsoft.AspNetCore.Mvc;
using WepAPI_Restaurant_Management.Data;
using WepAPI_Restaurant_Management.Models;

namespace WepAPI_Restaurant_Management.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderItemController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public OrderItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<OrderItem> Get()
        {
            return _context.OrderItem.ToList();
        }
    }
}
