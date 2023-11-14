using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VisitaFacil.Dados;
using VisitaFacil.Dominio.Entities;
//using VisitaFacil.Servico;
using VisitaFacil.WebApp.Models;

namespace VisitaFacil.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private Contexto db = new Contexto();


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IdosoFormulario()
        {
            return View();
        }

        public IActionResult VisitanteFormulario()
        {

            return View();
        }

        public IActionResult VisitaFormulario()
        {
            // Preencher listas suspensas com registros existentes no banco
            ViewBag.Idosos = db.Idoso.ToList();
            ViewBag.Visitantes = db.Visitante.ToList();
            return View(new Visita());
        }

        //public IActionResult Entrar()
        //{
        //    return View();
        //}


        public IActionResult Login() // nao sei se está certo 
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }

        public IActionResult Cadastros()
        {
            return View();
        }
    }
}