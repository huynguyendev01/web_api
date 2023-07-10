using Microsoft.AspNetCore.Mvc;
using WepAPI_Restaurant_Management.Data;
using WepAPI_Restaurant_Management.Models;


namespace WepAPI_Restaurant_Management.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Lấy tất cả danh sách Users
        /// </summary>
        /// <returns>Danh sách Users</returns>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.Users.ToList();
        }

        /// <summary>
        /// Lấy User với Id
        /// </summary>
        /// <returns>User</returns>
        /// <param name="Id">Tham số là Id của User</param>
        [HttpGet("Id")]
        public Object Get([FromQuery] int Id)
        {
            return _context.Users.Where(user => user.Id == Id).Select(s => new
            {
                Id = s.Id,
                UserName = s.Name
            }).FirstOrDefault();
        }

        /// <summary>
        /// Thêm User mới
        /// </summary>
        /// <returns>Danh sách Users</returns>
        [HttpPost]
        public User Post([FromQuery] User User)
        {
            _context.Users.Add(User);
            _context.SaveChanges();
            return User;
        }

        /// <summary>
        /// Thêm User mới
        /// </summary>
        /// <returns>Danh sách Users</returns>
        [HttpPut]
        public User Put([FromQuery] User User)
        {
            var user = _context.Users.Find(User.Id);
            if (user == null)
            {
                return null;
            }
            user.Name = User.Name;
            user.Password = User.Password;
            _context.SaveChanges();
            return user;
        }
    }
}
