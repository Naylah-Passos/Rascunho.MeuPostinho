using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MeuPostinhoAPI.Services
{
    private string baseUrl = "https://10.0.2.2:5001/api";

    public async Task CriarUsuario(Usuario user)
    {
        var json = JsonSerializer.Serialize(user);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        await _http.PostAsync($"{baseUrl}/usuarios", content);
    }

    public async Task<List<Usuario>> ListarUsuarios()
    {
        var response = await _http.GetStringAsync($"{baseUrl}/usuarios");
        return JsonSerializer.Deserialize<List<Usuario>>(response);
    }
}
