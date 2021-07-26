using GenikosApp.Data;
using GenikosApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GenikosApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataAPIController : ControllerBase
    {
        // GET: api/<DataAPIController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DataAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DataAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DataAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DataAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private DatabaseQuery db = new DatabaseQuery();
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IServiceProvider _serviceProvider;

        public DataAPIController(UserManager<IdentityUser> _userManager)
        {
            userManager = _userManager;
        }

        // GET: api/<controller>
        [Route("api/GetAllUsers")]
        [HttpGet]
        public IEnumerable<BUser> GetAllUsers()
        {
            var _users = new List<BUser>();
            //_users = db.GetAllUsers();

            return _users;
        }

    }
}
