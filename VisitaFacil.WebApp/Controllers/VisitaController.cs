using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using VisitaFacil.Dados;
using VisitaFacil.Dominio.Entities;

namespace VisitaFacil.WebApp.Controllers
{
    public class VisitaController : Controller
    {
     
            private Contexto db = new Contexto();

            public IActionResult Inserir()
            {
                var ent = new Visita();

              

                return View(ent);
            }

            [HttpPost]
            public IActionResult Post(Visita ent)
            {
                // Salvar a visita no banco de dados
                db.Visita.Add(ent);
                db.SaveChanges();

                return RedirectToAction("Index", "Visita");
            }
        

    }
}
