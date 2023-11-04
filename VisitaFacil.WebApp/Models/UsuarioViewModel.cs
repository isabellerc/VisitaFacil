namespace VisitaFacil.WebApp.Models
{
    public class UsuarioViewModel
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public bool ManterConectado { get; set; }
        public bool Autenticado()
        {
            return (Usuario == "isabelle@gmail.com" && Senha == "123")||(Usuario == "vitorhugo@gmail.com" && Senha == "321") || (Usuario == "renatinho@gmail.com" && Senha == "medaponto");
        }
    }
}
