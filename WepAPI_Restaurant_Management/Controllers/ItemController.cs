using Microsoft.AspNetCore.Mvc;
using WepAPI_Restaurant_Management.Data;
using WepAPI_Restaurant_Management.Models;

namespace WepAPI_Restaurant_Management.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _context.Items.ToList();
        }
    }
}
