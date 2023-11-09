using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitaFacil.Dominio.Entities;

namespace VisitaFacil.Dados.Repositorios
{
    public class IdosoRepositorio : RepositorioBase<Idoso>
    {
        public IEnumerable<Idoso> ListarIdoso()
        {
            return Contexto
                .Idoso
                .Where(f => f.idIdoso > 0);
        }
    }
}
