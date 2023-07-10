using Microsoft.AspNetCore.Mvc;
using WepAPI_Restaurant_Management.Data;
using WepAPI_Restaurant_Management.Models;

namespace WepAPI_Restaurant_Management.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuestTableController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public GuestTableController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<GuestTable> Get()
        {
            return _context.GuestTable.ToList();
        }
    }
}
