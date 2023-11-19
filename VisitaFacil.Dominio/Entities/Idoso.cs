using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitaFacil.Models.Validations;

namespace VisitaFacil.Dominio.Entities
{
    public class Idoso 
    {
        [Key]
        public int idIdoso { get; set; }
        public string Nome { get; set; }
        //[CpfValidation(ErrorMessage = "CPF inválido.")]
        public string Cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public List<Visita> Visitas { get; set; } // Propriedade de navegação para as visitas associadas ao Idoso
    }
}
