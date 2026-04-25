using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using MeuPostinhoAPI.Models;

namespace MeuPostinhoAPI.Helpers
{
    public class NotificacaoHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public NotificacaoHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Notificacao>().Wait();
        }

        public Task<int> Insert(Notificacao n)
        {
            return _conn.InsertAsync(n);
        }

        public Task<int> Delete(int id)
        {
            return _conn.Table<Notificacao>().DeleteAsync(i => i.IdNotificacao == id);
        }

        public Task<List<Notificacao>> GetAll()
        {
            return _conn.Table<Notificacao>().ToListAsync();
        }

        public Task<List<Notificacao>> GetByUsuario(int idUsuario)
        {
            return _conn.Table<Notificacao>()
                        .Where(n => n.IdUsuario == idUsuario)
                        .ToListAsync();
        }
    }
}