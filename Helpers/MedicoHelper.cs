using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using MeuPostinhoAPI.Models;

namespace MeuPostinhoAPI.Helpers
{
    public class MedicoHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public MedicoHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Medico>().Wait();
        }

        public Task<int> Insert(Medico m)
        {
            return _conn.InsertAsync(m);
        }

        public Task<int> Update(Medico m)
        {
            return _conn.UpdateAsync(m);
        }

        public Task<int> Delete(int id)
        {
            return _conn.Table<Medico>().DeleteAsync(i => i.IdMedico == id);
        }

        public Task<List<Medico>> GetAll()
        {
            return _conn.Table<Medico>().ToListAsync();
        }
    }
}