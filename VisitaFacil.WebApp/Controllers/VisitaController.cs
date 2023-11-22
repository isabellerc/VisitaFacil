using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using VisitaFacil.Dados;
using VisitaFacil.Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace VisitaFacil.WebApp.Controllers
{
    public class VisitaController : Controller
    {
     
            private Contexto db = new Contexto();

        public IActionResult Index()
        {
            var resultado = db.Visita
                .ToList();

            return View(resultado);
        }

        public IActionResult Inserir()
            {
                var ent = new Visita();
                return View(ent);
            }

        public IActionResult Editar(int id)
        {
            Visita entidade = db.Visita.Find(id);
            if (entidade == null)
            {
                return NotFound();
            }
            return View(entidade);
        }

        [HttpPost]
        public IActionResult Editar(Visita ent)
        {
            ModelState.Remove("Idoso");
            ModelState.Remove("Visitante");
            if (ModelState.IsValid)
            {
                db.Entry(ent).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ent);
        }

        [HttpPost]
            public IActionResult Post(Visita ent)
            {
                // Salvar a visita no banco de dados
                db.Visita.Add(ent);
                db.SaveChanges();

                return RedirectToAction("Index", "Visita"); // está redirecionando errado
            }
        

    }
}
