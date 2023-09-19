using System;

public class ClassEntities
{
    public class Instituicao()
    {
        public int codigoInstituicao { get; set; }
        public string razaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }

    public class Visitante()
    {
        public DadosPessoais();
    }

    public class Idoso()
    {
        public string nomeCompleto { get; set; }
        public string cpf { get; set; }
        public string parenteProximo { get; set; }
    }

    public class ParenteProximo()
    {
        public string DadosPessoais { get; set; }
    }

    public class Funcionario()
    {
        public string DadosPessoais { get; set; }
    }

    public class Usuario()
    {
        public string nomeCompleto { get; set; }
        public string cpf { get; set; }
        public string login { get; set; }
    }

    public class Cadastro()
    {
        public string DadosPessoais()
        {

        }
    }

    public class RegistroVisita()
    {
        public DadosPessoais();
        public DateTime data { get; set; }
        public DateTime hora { get; set; }
        public string Visitante()
        public string Idoso()
    }

    public class Endereco()
    {
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }

    public class Login()
    {
        public string usuario { get; set; }
        public string senha { get; set; }
    }

    public string DadosPessoais()
    {
        public string nomeCompleto { get; set; }
        public string cpf { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
    }

}
