using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitaFacil.Dominio.Entities;

namespace VisitaFacil.Dados.Repositorios
{
    public class DadosPessoaisRepositorio : RepositorioBase<DadosPessoais>
    {
        public IEnumerable<DadosPessoais> ListarDadosPessoais()
        {
            return Contexto
                .DadosPessoais
                .Where(f => f.ID > 0);
        }
    }
}
