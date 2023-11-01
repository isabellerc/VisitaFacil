using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitaFacil.Dominio.Entities
{
    public class Idoso : DadosPessoais
    {
       public int idIdoso { get; set; }
        public ParenteProximo parenteProximo { get; set; }
    }
}
