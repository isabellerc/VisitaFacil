using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitaFacil.Dominio
{
    public class Login
    {
        public Funcionario Funcionario { get; set; } // talvez retirar... precisa dele?
        public string cpf { get; set; }
        public string senha { get; set; }
    }
}
