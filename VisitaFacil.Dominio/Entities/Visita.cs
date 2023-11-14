using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace VisitaFacil.Dominio.Entities
{
    public class Visita
    {
        public int idVisita { get; set; }
        public int idIdoso { get; set; }
        public int idVisitante { get; set; }

        public DateTime dataVisita { get; set; }
        
        public TimeSpan horaEntrada { get; set; }
        public TimeSpan horaSaida { get; set; }

        public Idoso Idoso { get; set; }
        public Visitante Visitante { get; set; }
    }

}
