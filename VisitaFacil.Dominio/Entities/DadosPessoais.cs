using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitaFacil.Dominio.Entities
{
    public class DadosPessoais
    {
        public string nomeCompleto { get; set; }
        public string cpf { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public Endereco endereco { get; set; }
    }
}
