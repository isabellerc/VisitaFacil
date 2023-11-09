using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitaFacil.Dominio.Entities;

namespace VisitaFacil.Dados.Repositorios
{
    public class VisitanteRepositorio : RepositorioBase<Visitante>
    {
        public IEnumerable<Visitante> ListarVisitante()
        {
            return Contexto
                .Visitante
                .Where(f => f.idVisitante > 0);
        }
    }
}
