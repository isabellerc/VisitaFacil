using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using VisitaFacil.Dados.Repositorios;
using VisitaFacil.Dominio.Entities;

namespace VisitaFacil.Servico
{//esse dados pessoais serviço nao tem no codigo do rento
    public class DadosPessoaisServico 
    {
        private readonly DadosPessoaisRepositorio _dadosPessoaisRepositorio;

        public DadosPessoaisServico()
        {
            _dadosPessoaisRepositorio = new DadosPessoaisRepositorio();
        }

        public string SalvarDadosPessoais(DadosPessoais dadosPessoais)
        {
            _dadosPessoaisRepositorio.Adicionar(dadosPessoais);
            return "Ok";
        }
        
    }
}
