using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitaFacil.Dominio.Entities
{
    public class Visitante 
    {
        [Key]
        public int idVisitante { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime dataNascimento { get; set; }

        public string Endereco { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }

    }
}
