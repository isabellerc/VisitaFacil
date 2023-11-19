using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitaFacil.Models.Validations;
//using VisitaFacil.Dados;
//using VisitaFacil.Dados.EntityFramework.Configuration;
//using VisitaFacil.Dados.Repositorios;


namespace VisitaFacil.Dominio.Entities
{
    public class DadosPessoais
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        //[CpfValidation(ErrorMessage = "CPF inválido.")]
        public string Cpf { get; set; }
        public DateTime dataNascimento { get; set; }

        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        public string Numero { get; set; } //alterar no banco para int
        public string Complemento { get; set; }
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        public string Telefone { get; set; }
        public string Email { get; set; }
    
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        
    }
}
