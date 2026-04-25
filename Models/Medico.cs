using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MeuPostinhoAPI.Models
{
    public class Medico
    {
        [PrimaryKey, AutoIncrement]
        public int IdMedico { get; set; }

        [NotNull, MaxLength(100)]
        public string Nome { get; set; }

        [NotNull]
        public string Especialidade { get; set; }

        [NotNull]
        public int IdUBS { get; set; }
    }
}
