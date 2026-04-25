using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace MeuPostinhoAPI.Models
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int IdUsuario { get; set; }

        [NotNull, MaxLength(100)]
        public string Nome { get; set; }

        [NotNull]
        public string CPF { get; set; }

        public string DatasNascimento { get; set; }
        public string Endereco { get; set; }

        [NotNull, MaxLength(20)]
        public string Telefone { get; set; }

        [NotNull, MaxLength(100)]
        public string Email { get; set; }

        [NotNull]
        public string Senha { get; set; }

        public string TipoUsuario { get; set; }

        public List<Agendamento> Agendamentos { get; set; }
    }
}
