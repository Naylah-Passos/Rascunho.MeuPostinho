using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using MeuPostinhoAPI.Models;

namespace MeuPostinhoAPI.Helpers
{
    public class EstoqueHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public EstoqueHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Estoque>().Wait();
        }

        public Task<int> Insert(Estoque e)
        {
            return _conn.InsertAsync(e);
        }

        public Task<int> Update(Estoque e)
        {
            return _conn.UpdateAsync(e);
        }

        public Task<List<Estoque>> GetAll()
        {
            return _conn.Table<Estoque>().ToListAsync();
        }
    }
}