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

        public DateTime Data { get; set; }
        public string Hora { get; set; }
        public string Status { get; set; }

        public int IdUsuario { get; set; }
        public int IdMedico { get; set; }
        public int UbsId { get; set; }
    }
}
