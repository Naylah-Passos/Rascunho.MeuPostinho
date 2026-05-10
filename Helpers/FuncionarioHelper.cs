using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuPostinhoAPI.Models;
using SQLite;
using MeuPostinho.Models;

namespace MeuPostinho.Helpers
{
    public class FuncionarioHelper
    {
        readonly SQLiteAsyncConnection _conn;

        public FuncionarioHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Funcionario>().Wait();
        }

        public Task<int> Insert(Funcionario f)
        {
            return _conn.InsertAsync(f);
        }

        public Task<int> Update(Funcionario f)
        {
            return _conn.UpdateAsync(f);
        }

        public Task<int> Delete(Funcionario f)
        {
            return _conn.DeleteAsync(f);
        }

        public Task<List<Funcionario>> GetAll()
        {
            return _conn.Table<Funcionario>().ToListAsync();
        }
    }
}