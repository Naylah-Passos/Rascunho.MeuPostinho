using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MeuPostinhoAPI.Models
{
    public class Relatorio
    {
        [PrimaryKey, AutoIncrement]
        public int IdRelatorio { get; set; }

        [NotNull]
        public string Tipo { get; set; }

        [NotNull]
        public DateTime DataGeracao { get; set; }

        [NotNull]
        public string Descricao { get; set; }

        [NotNull]
        public int IdUsuario { get; set; }
    }
}
