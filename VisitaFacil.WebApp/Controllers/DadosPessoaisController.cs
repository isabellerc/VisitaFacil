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
        [HttpPost]
        public IActionResult Login(DadosPessoais ent)
        {
            var criarUsuarioLogin = new UsuarioViewModel();
            criarUsuarioLogin.Usuario = ent.Email;
            criarUsuarioLogin.Senha = ent.Cpf;
            if (criarUsuarioLogin.Autenticado())
            {
                return RedirectToAction("Index","DadosPessoais");
            }
            return RedirectToAction("Login","Home");
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
    }

}

