using Microsoft.AspNetCore.Mvc;
using VisitaFacil.WebApp.Models;

namespace VisitaFacil.WebApp.Controllers
{
    public class AutenticadorController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UsuarioViewModel());
        }

        [HttpPost]
        public IActionResult Autenticar(UsuarioViewModel entidade)
        {
            if (entidade.Autenticado())
                return base.RedirectToAction("Index", "DadosPessoais");
            //if (entidade.Autenticado())
            //    return base.RedirectToAction("Index", "Home");
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
