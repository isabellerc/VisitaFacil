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
            var ent = db.Visita.Find(id);

            if (ent == null)
            {
                return NotFound(); 
            }

            return View(ent);
        }

        [HttpPost]
        public IActionResult Editar(Visita ent)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(ent).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["Mensagem"] = "Alterações salvas com sucesso.";
                    return RedirectToAction("VisitaFormulario", "Home");
                }
                catch (Exception ex)
                {
                    TempData["Erro"] = $"Erro ao salvar alterações: {ex.Message}";
                }
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
