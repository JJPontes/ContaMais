using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back.src.ContaMais.WebApi.Models;
using ContaMais.WebApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ContaMais.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly DataContext _context;

        //private readonly ILogger<LoginController> _logger;

        //public LoginController(ILogger<LoginController> logger)
        public LoginController(DataContext context)
        {
            _context = context;
            // _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Users> Get()
        {
           return _context.Users;
        }
        
        [HttpGet("{id}")]
        //public IEnumerable<Users> GetById(int id)
        public Users GetById(int id)
        {
           //return _context.Users.Where(users => users.UserID == id);
           return _context.Users.FirstOrDefault(users => users.UserID == id);
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
