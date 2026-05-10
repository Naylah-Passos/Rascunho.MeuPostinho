using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuPostinho.Models;
using SQLite;

namespace MeuPostinho.Helpers
{
    public class AdministradorHelper
    {
        readonly SQLiteAsyncConnection _conn;
        public AdministradorHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Administrador>().Wait();
        }
        public Task<int> Insert(Administrador Ad)
        {
            return _conn.InsertAsync(Ad);
        }
        public Task<int> Update(Administrador Ad)
        {
            return _conn.UpdateAsync(Ad);
        }
        public Task<int> Delete(Administrador Ad)
        {
            return _conn.DeleteAsync(Ad);
        }
        public Task<List<Administrador>> GetAll()
        {
            return _conn.Table<Administrador>().ToListAsync();
        }
    }
}