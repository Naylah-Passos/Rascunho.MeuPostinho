using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MeuPostinhoAPI.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login(Usuario login)
        {
            var user = _context.Usuarios
                .FirstOrDefault(u => u.Email == login.Email && u.Senha == login.Senha);

            if (user == null)
                return Unauthorized();

            return Ok(user);
        }
    }
}
