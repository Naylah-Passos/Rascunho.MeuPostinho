using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuPostinhoAPI.Models;
using SQLite;

namespace MeuPostinhoAPI.Helpers
{
    public class UsuarioHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public UsuarioHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
        }

        public Task<int> Insert(Usuario u)
        {
            return _conn.InsertAsync(u);
        }

        public Task<int> Update(Usuario u)
        {
            return _conn.UpdateAsync(u);
        }

        public Task<int> Delete(int id)
        {
            return _conn.Table<Usuario>().DeleteAsync(i => i.IdUsuario == id);
        }

        public Task<List<Usuario>> GetAll()
        {
            return _conn.Table<Usuario>().ToListAsync();
        }

        public Task<List<Usuario>> Login(string email, string senha)
        {
            string sql = "SELECT * FROM Usuario WHERE Email=? AND Senha=?";
            return _conn.QueryAsync<Usuario>(sql, email, senha);
        }
    }
}