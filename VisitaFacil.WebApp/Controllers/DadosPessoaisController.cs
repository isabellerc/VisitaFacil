using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VisitaFacil.Dados;
using VisitaFacil.Dominio.Entities;
using VisitaFacil.WebApp.Models;

namespace VisitaFacil.WebApp.Controllers
{
    public class DadosPessoaisController : Controller
    {
       
        private Contexto db = new Contexto();
        public IActionResult Index()
        {
            var resultado = db.DadosPessoais
                .ToList();

            return View(resultado);
        }

        public IActionResult Inserir()
        {
            var ent = new DadosPessoais();
            return View(ent);
        }

        [HttpPost]
        public IActionResult Post(DadosPessoais ent)
        {
            db.DadosPessoais.Add(ent);
            db.SaveChanges();
            return RedirectToAction("Login","Home");
            
        }
      
        public IActionResult Editar(int id)
        {
            DadosPessoais entidade = db.DadosPessoais.Find(id);
            if (entidade == null)
            {
                return NotFound();
            }
            return View(entidade);
        }

        [HttpPost]
        public IActionResult Editar(DadosPessoais ent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ent).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ent);
        }

        public IActionResult Excluir(int ID)
        {
            var objeto = db
                .DadosPessoais
                .First(f => f.ID == ID);

            db.DadosPessoais.Remove(objeto);
            db.SaveChanges();

            return RedirectToAction("Index");
        }    

        [HttpGet]
        public IActionResult Login()
        {
        return View();
        }
    }
}