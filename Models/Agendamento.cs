using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MeuPostinhoAPI.Models
{
    public class Agendamento
    {
        [PrimaryKey, AutoIncrement]
        public int IdAgendamento { get; set; }

        [NotNull]
        public DateTime Data { get; set; }

        [NotNull]
        public string Hora { get; set; }

        [NotNull, MaxLength(20)]
        public string Status { get; set; }

        [NotNull]
        public int IdUsuario { get; set; }

        [NotNull]
        public int IdMedico { get; set; }

        [NotNull]
        public int UbsId { get; set; }
    }
}
