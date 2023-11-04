using Microsoft.AspNetCore.Mvc;
using VisitaFacil.WebApp.Models;

namespace VisitaFacil.WebApp.Controllers
{
    public class AutenticadorController : Controller
    {

        //comentando , mas depois tenho que voltar aqui pra resolver o erro
        [HttpGet]
        public IActionResult Index()
        {
            return View(new UsuarioViewModel());
        }

        //public IActionResult Login() // nao sei se está certo
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Autenticar(UsuarioViewModel entidade)
        {
            if (entidade.Autenticado())
                return base.RedirectToAction("Index", "DadosPessoais");
            else
                return base.RedirectToAction("Erro");
        }

        [HttpGet]
        public IActionResult Erro()
        {
            return View();
        }
    }
}
