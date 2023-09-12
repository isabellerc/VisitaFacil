using Microsoft.AspNetCore.Mvc;
using VisitaFacil.WebApp.Models;

namespace VisitaFacil.WebApp.Controllers
{
    public class AutenticadorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Login");
        }

        //public IActionResult Login() // nao sei se está certo
        //{
        //    return View();
        //}

        [HttpPost]
        public async Task<IActionResult> Autenticar(UsuarioViewModel entidade)
        {
            if (entidade.Autenticado())
                await Response.WriteAsync("Resultado Positivo");
            else
                await Response.WriteAsync("Resultado Negativo");
            return null;
        }
    }
}
