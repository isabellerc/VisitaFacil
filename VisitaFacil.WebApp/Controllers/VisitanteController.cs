using Microsoft.AspNetCore.Mvc;
using VisitaFacil.Dados;
using VisitaFacil.Dominio.Entities;

namespace VisitaFacil.WebApp.Controllers
{
    public class VisitanteController : Controller
    {
        private Contexto db = new Contexto();
        public IActionResult Index()
        {
            var resultado = db.Visitante
                .ToList();

            return View(resultado);
        }

        public IActionResult Inserir()
        {
            var ent = new Visitante();
            return View(ent);
        }




        [HttpPost]
        public IActionResult Post(Visitante ent)
        {
            db.Visitante.Add(ent);
            db.SaveChanges();
            return RedirectToAction("VisitanteFormulario", "Home");

        }
    }
}
