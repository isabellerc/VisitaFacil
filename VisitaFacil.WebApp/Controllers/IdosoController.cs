using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VisitaFacil.Dados;
using VisitaFacil.Dominio.Entities;
using VisitaFacil.WebApp.Models;

namespace VisitaFacil.WebApp.Controllers
{
        public class IdosoController : Controller
        {

            private Contexto db = new Contexto();
            public IActionResult Index()
            {
                var resultado = db.Idoso
                    .ToList();

                return View(resultado);
            }

            public IActionResult Inserir()
            {
                var ent = new Idoso();
                return View(ent);
            }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }

        [HttpPost]
        public IActionResult Post(Idoso ent)
        {
            db.Idoso.Add(ent);
            db.SaveChanges();
            return RedirectToAction("IdosoFormulario", "Home");
        }

        public IActionResult Editar(int id)
        {
            Idoso entidade = db.Idoso.Find(id);
            if (entidade == null)
            {
                return NotFound();
            }
            return View(entidade);
        }

        [HttpPost]
        public IActionResult Editar(Idoso ent)
        {
            ModelState.Remove("Visitas");
            if (ModelState.IsValid)
            {
                db.Entry(ent).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
            //return View(ent);
        }

        public IActionResult Excluir(int ID)
        {
            var objeto = db
                .Idoso
                .First(f => f.idIdoso == ID);

            db.Idoso.Remove(objeto);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}