using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SyamDatingAppV_1.Data;
using SyamDatingAppV_1.Entities;
namespace SyamDatingAppV_1.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public UsersController(entityData context)
        {
            _context = context;
        }
        private readonly entityData _context;


        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var users = _context.User.ToList();
            return users;
        }

        [HttpGet("id")]
        []
        public ActionResult<AppUser> GetUserById(int id)
        {
            var user = _context.User.Find(id);

            return user;
        }




    }
}
