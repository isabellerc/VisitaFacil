using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitaFacil.Dominio.Entities
{
    public class Visita
    {
        public int idVisita { get; set; }
        public int idIdoso { get; set; }
        public int idVisitante { get; set; }

        public DateTime dataVisita { get; set; }
        public DateTime horaEntrada { get; set; }
        public DateTime horaSaida { get; set; }

        public Idoso Idoso { get; set; }
        public Visitante Visitante { get; set; }
    }

}
