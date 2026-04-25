using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuPostinhoAPI.Models
{
    public class UBS
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string HorarioFuncionamento { get; set; }

        public List<Medicamento> Medicamentos { get; set; }
    }
}
