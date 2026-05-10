using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuPostinhoAPI.Models;

namespace MeuPostinhoAPI.Helpers
{
    public class UBSHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public UBSHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<UBS>().Wait();
        }

        public Task<int> Insert(UBS u)
        {
            return _conn.InsertAsync(u);
        }

        public Task<List<UBS>> GetAll()
        {
            return _conn.Table<UBS>().ToListAsync();
        }
    }
}
