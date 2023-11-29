//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using VisitaFacil.Dados;
//using VisitaFacil.Dominio.Entities;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VisitaFacil.Dados;
using VisitaFacil.Dominio.Entities;
using VisitaFacil.WebApp.Models;

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
        public IActionResult Editar(int id)
        {
            Visitante entidade = db.Visitante.Find(id);
            if (entidade == null)
            {
                return NotFound();
            }
            return View(entidade);
        }

        [HttpPost]
        public IActionResult Editar(Visitante ent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ent).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ent);
        }
    }
}
