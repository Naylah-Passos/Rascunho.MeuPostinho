using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MeuPostinhoAPI.Models
{
    public class Estoque
    {
        [PrimaryKey, AutoIncrement]
        public int IdMedicamento { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
