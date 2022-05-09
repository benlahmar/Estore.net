using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.Entities;
using UserService.Repository;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private ILogger<UsersController> _logger;
        private readonly IUser urepo;

        public UsersController(IUser urepo, ILogger<UsersController> logger)
        {
            this.urepo = urepo;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult save([FromBody] User u)
        { 
            int nb=urepo.save(u);
            return Ok(nb);
            
        }

        [HttpGet]
        public IActionResult allusers()
        {
            IEnumerable<User> us = urepo.findall();
            return Ok(us);
        }

        [HttpGet("/{id}")]
        public IActionResult Find(int id)
        {
           User u = urepo.findone(id);
            if(u!=null)
            return Ok(u);
            else
                return NotFound();
        }
    }
}
