﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitaFacil.Dominio.Entities
{
    public class Funcionario : DadosPessoais
    {
        
        public int idFuncionario { get; set; }
        public string funcao { get; set; }
        public Login login { get; set; } // verificar... talvez retirar

    }
}
