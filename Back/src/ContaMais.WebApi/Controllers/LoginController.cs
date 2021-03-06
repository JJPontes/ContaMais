using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back.src.ContaMais.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ContaMais.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        public IEnumerable<Users> _users = new Users[]
        {
            new Users(){
                UserID = 1,
                Name = "Julio",
                LoginName = "JJPontes",
                Password = "123",
                Role = "Manager"
            }
        };

        //private readonly ILogger<LoginController> _logger;

        //public LoginController(ILogger<LoginController> logger)
        public LoginController()
        {
           // _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Users> Get()
        {
           return _users;
        }
        
        [HttpGet("{id}")]
        public IEnumerable<Users> GetById(int id)
        {
           return _users.Where(users => users.UserID == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id={id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id= {id}";
        }
    }
}
