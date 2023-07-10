using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WepAPI_Restaurant_Management.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WepAPI_Restaurant_Management.Models;

namespace WepAPI_Restaurant_Management.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UnitController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UnitController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Unit>>> Get()
        {
            try
            {
                var data = await _context.Units
                        .AsNoTracking()
                        .Where(u => (bool)!u.Deleted)
                        .ToArrayAsync();
                var model = _mapper.Map<IEnumerable<Unit>>(data);
                return new JsonResult(model);
            }
            catch (ArgumentException ex)
            {
                return BadRequest("not good");
            }
        }
    }
}
