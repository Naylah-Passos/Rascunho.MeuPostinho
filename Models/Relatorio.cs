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

        public string Tipo { get; set; }
        public string DataGeracao { get; set; }
        public string Descricao { get; set; }

        public int IdUsuario { get; set; }
    }
}
