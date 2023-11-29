using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitaFacil.Models.Validations;

namespace VisitaFacil.Dominio.Entities
{
    public class Funcionario : DadosPessoais
    {
        [Key]
        public int idFuncionario { get; set; }

        public string Nome { get; set; }
        [CpfValidation(ErrorMessage = "CPF inválido.")]
        public string Cpf { get; set; }
        public DateTime dataNascimento { get; set; }

        public string Endereco { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
}
