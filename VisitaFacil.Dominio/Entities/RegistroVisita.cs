using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitaFacil.Dominio
{
    public class RegistroVisita
    {
        public Visitante visitante { get; set; }
        public Idoso idoso { get; set; }

        public DateTime data { get; set; }
        public DateTime hora { get; set; }
       
    }
}
