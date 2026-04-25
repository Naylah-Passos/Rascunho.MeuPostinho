using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MeuPostinhoAPI.Models
{
    public class Notificacao
    {
        [PrimaryKey, AutoIncrement]
        public int IdNotificacao { get; set; }

        [NotNull]
        public string Mensagem { get; set; }

        [NotNull]
        public string DataEnvio { get; set; }

        [NotNull]
        public int IdUsuario { get; set; }
    }
}
