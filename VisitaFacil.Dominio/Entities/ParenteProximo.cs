﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitaFacil.Dominio.Entities
{
    public class ParenteProximo : DadosPessoais
    {
        public DadosPessoais dadosPessoais { get; set; }
        public string vinculoIdoso { get; set; }
    }
}
