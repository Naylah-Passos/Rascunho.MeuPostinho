using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeuPostinhoAPI.Models;
using SQLite;

namespace MeuPostinhoAPI.Helpers
{
    public class MedicamentoHelper
    {
        readonly SQLiteAsyncConnection _conn;
        
        public MedicamentoHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Medicamento>().Wait();
        }
        
        public Task<int> Insert(Medicamento m)
        {
            return _conn.InsertAsync(m);
        }
        
        public Task<int> Update(Medicamento m)
        {
            return _conn.UpdateAsync(m);
        }
        
        public Task<int> Delete(int id)
        {
            return _conn.Table<Medicamento>().DeleteAsync(i => i.IdMedicamento == id);
        }
        
        public Task<List<Medicamento>> GetAll()
        {
            return _conn.Table<Medicamento>().ToListAsync();
        }
    }
}