//using Fluent.Infrastructure.FluentModel;
//using Microsoft.AspNetCore.Mvc;
//using VisitaFacil.Dominio.Entities;
//using VisitaFacil.WebApp.Controllers;
//using VisitaFacil.Dados.Repositorios;


//namespace VisitaFacil.WebApp.Controllers
//{

//    public class DadosPessoaisController : Controller
//    {
//        private readonly ApplicationDbContext _context;

//        public DadosPessoaisController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        [HttpPost]
//        public IActionResult SalvarDadosPessoais(DadosPessoais dados)
//        {
//            if (ModelState.IsValid)
//            {
//                _context.DadosPessoais.Add(dados);
//                _context.SaveChanges();
//                return RedirectToAction("Sucesso"); // Redireciona para uma página de sucesso
//            }
//            // Se os dados não forem válidos, você pode retornar uma visão com mensagens de erro
//            return View("Formulario", dados);
//        }

//        public IActionResult Formulario()
//        {
//            return View();
//        }
//    }


//}
