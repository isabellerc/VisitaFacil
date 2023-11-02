using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitaFacil.Dominio.Entities
{
    public class Instituicao
    {
        [Key]
        public int IDINSTITUICAO { get; set; }
        public string razaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string logradouro { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public bool Ativo { get; set; }
    }
}
