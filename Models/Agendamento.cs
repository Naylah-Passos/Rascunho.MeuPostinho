using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPostinhoAPI.Models
{
    public class Agendamento
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }
        public string Status { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int UbsId { get; set; }
        public UBS Ubs { get; set; }
    }
}
