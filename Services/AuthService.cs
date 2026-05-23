using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPostinhoAPI.Services
{
    public class AuthService
    {
        public Task<string?> LoginAsync(string email, string senha)
        {
            // Login administrador
            if (email == "admin@teste.com" && senha == "123")
                return Task.FromResult<string?>("admin");

            // Login paciente
            if (email == "user@teste.com" && senha == "123")
                return Task.FromResult<string?>("user");

            return Task.FromResult<string?>(null);
        }
    }
}