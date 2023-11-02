using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VisitaFacil.Dominio.Entities;
using VisitaFacil.Servico;
using VisitaFacil.WebApp.Models;

namespace VisitaFacil.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        private readonly DadosPessoaisServico dadosPessoaisServico;
        public DadosPessoaisServico _dadosPessoaisServico = new DadosPessoaisServico();
        //[HttpPost]

        public IActionResult SalvarDadosPessoais(VisitaFacil.Dominio.Entities.DadosPessoais dadosPessoais)
        {
            _dadosPessoaisServico.SalvarDadosPessoais(dadosPessoais);
            return Ok();
        }


        //comentei isso para testar:
        //public string SalvarDadosPessoais(DadosPessoais dadosPessoais)
        //{
        //    _dadosPessoaisServico.SalvarDadosPessoais(dadosPessoais);
        //    return "Ok";
        //}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login() // nao sei se está certo 
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}