using Microsoft.AspNetCore.Mvc;
using API.Data;
using System.Collections.Generic;
using API.Entities;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase
    
    {
        private readonly DataContext _context;
        public UsersController(DataContext context){

        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers(){
           
            return _context.Users.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUsers(int id){
     
            return _context.Users.Find(id);
        }
    }
}