using Microsoft.AspNetCore.Mvc;
using WepAPI_Restaurant_Management.Data;
using WepAPI_Restaurant_Management.Models;

namespace WepAPI_Restaurant_Management.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public GuestController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Guest> Get()
        {
            return _context.Guest.ToList();
        }
    }
}
