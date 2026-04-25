using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuPostinhoAPI.Models;
using SQLite;

namespace MeuPostinhoAPI.Helpers
{
    public class AgendamentoHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public AgendamentoHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Agendamento>().Wait();
        }

        public Task<int> Insert(Agendamento a)
        {
            return _conn.InsertAsync(a);
        }

        public Task<int> Update(Agendamento a)
        {
            return _conn.UpdateAsync(a);
        }

        public Task<int> Delete(int id)
        {
            return _conn.Table<Agendamento>().DeleteAsync(i => i.IdAgendamento == id);
        }

        public Task<List<Agendamento>> GetAll()
        {
            return _conn.Table<Agendamento>().ToListAsync();
        }
    }
}