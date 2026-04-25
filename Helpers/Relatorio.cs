using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuPostinhoAPI.Models;

namespace MeuPostinhoAPI.Helpers
{
    public class RelatorioHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public RelatorioHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Relatorio>().Wait();
        }

        public Task<int> Insert(Relatorio r)
        {
            return _conn.InsertAsync(r);
        }

        public Task<List<Relatorio>> GetAll()
        {
            return _conn.Table<Relatorio>().ToListAsync();
        }
    }
}