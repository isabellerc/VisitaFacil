using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VisitaFacil.Dados;
using VisitaFacil.Dominio.Entities;

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




            [HttpPost]
            public IActionResult Post(Idoso ent)
            {
                db.Idoso.Add(ent);
                db.SaveChanges();
                return RedirectToAction("Idoso", "Index");
            }

        //[HttpPost]
        //public IActionResult Login(Idoso ent)
        //{
        //    var criarUsuarioLogin = new UsuarioViewModel();
        //    criarUsuarioLogin.Usuario = ent.Email;
        //    criarUsuarioLogin.Senha = ent.Cpf;
        //    if (criarUsuarioLogin.Autenticado())
        //    {
        //        return RedirectToAction("Index", "Idso");
        //    }
        //    return RedirectToAction("Login", "Home");
        //}

        //public IActionResult Excluir(int ID)
        //{
        //    var objeto = db
        //        .Idoso
        //        .First(f => f.idIdoso == ID);

        //    db.Idoso.Remove(objeto);
        //    db.SaveChanges();

        //    return RedirectToAction("Index");
        //}
    }

    }



