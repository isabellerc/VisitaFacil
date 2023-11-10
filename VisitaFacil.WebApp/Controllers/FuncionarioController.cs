//using Microsoft.AspNetCore.Mvc;
//using VisitaFacil.Dados;
//using VisitaFacil.Dominio.Entities;
//using VisitaFacil.WebApp.Models;

//namespace VisitaFacil.WebApp.Controllers
//{
//    public class FuncionarioController : Controller
//    {
//        private Contexto db = new Contexto();

//        public IActionResult Index()
//        {
//            var resultado = db.Funcionario
//                .ToList();

//            return View(resultado);
//        }

//        public IActionResult Inserir()
//        {
//            var ent = new Funcionario();
//            return View(ent);
//        }

//        [HttpPost]
//        public IActionResult Post(Funcionario ent)
//        {
//            db.Funcionario.Add(ent);
//            db.SaveChanges();
//            return RedirectToAction("Login", "Home");

//        }
//        [HttpPost]
//        public IActionResult Login(Funcionario ent)
//        {
//            var criarUsuarioLogin = new UsuarioViewModel();
//            criarUsuarioLogin.Usuario = ent.Email;
//            criarUsuarioLogin.Senha = ent.Cpf;
//            if (criarUsuarioLogin.Autenticado())
//            {
//                return RedirectToAction("Index", "Funcionario");
//            }
//            return RedirectToAction("Login", "Home");
//        }

//        public IActionResult Excluir(int ID)
//        {
//            var objeto = db
//                .Funcionario
//                .First(f => f.ID == ID);

//            db.Funcionario.Remove(objeto);
//            db.SaveChanges();

//            return RedirectToAction("Index");
//        }
//        //[HttpPost]
//        //public IActionResult InserirConfirmar(Funcionario ent)
//        //{
//        //    db.Funcionario.Add(ent);
//        //    db.SaveChanges();
//        //    return RedirectToAction("Index");
//        //}

//        //public IActionResult Excluir(int funcionarioId)
//        //{
//        //    var objeto = db
//        //        .Funcionario
//        //        .First(f => f.IDFUNCIONARIO == funcionarioId);

//        //    db.Funcionario.Remove(objeto);
//        //    db.SaveChanges();

//        //    return RedirectToAction("Index");
//        //}

//    }
//}
