using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MeuPostinhoAPI.Models
{
    public class Medicamento
    {
        [PrimaryKey, AutoIncrement]
        public int IdMedicamento { get; set; }

        [NotNull, MaxLength(100)]
        public string Nome { get; set; }

        [NotNull]
        public string Descricao { get; set; }
    }
}
