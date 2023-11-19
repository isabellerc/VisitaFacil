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

        public IActionResult Editar(int id)
        {
            // Encontrar o Idoso que você deseja editar no banco de dados
            var ent = db.Idoso.Find(id);

            if (ent == null)
            {
                return NotFound(); // Retorna uma resposta 404 se o Idoso não for encontrado
            }

            return View(ent);
        }

        [HttpPost]
        public IActionResult Editar(Idoso ent)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(ent).State = EntityState.Modified;
                    db.SaveChanges();
                    TempData["Mensagem"] = "Alterações salvas com sucesso.";
                    return RedirectToAction("IdosoFormulario", "Home");
                }
                catch (Exception ex)
                {
                    TempData["Erro"] = $"Erro ao salvar alterações: {ex.Message}";
                }
            }

            return View(ent);
        }


        [HttpPost]
        public IActionResult Post(Idoso ent)
        {
            db.Idoso.Add(ent);
            db.SaveChanges();
            return RedirectToAction("IdosoFormulario", "Home");
        }


        //[HttpPost]
        //public IActionResult Post(Idoso ent)
        //{
        //    try
        //    {
        //        db.Idoso.Add(ent);
        //        db.SaveChanges();
        //        return RedirectToAction("IdosoFormulario", "Home");
        //    }
        //    catch (Exception ex)
        //    {
        //        // Aqui você pode logar a exceção se desejar
        //        // Exemplo: logger.LogError($"Erro ao processar o post: {ex.Message}");

        //        // Retorne uma mensagem de erro para a tela
        //        ViewBag.ErrorMessage = "Ocorreu um erro ao processar a solicitação. Por favor, tente novamente.";
        //        return View("Error"); // Supondo que você tenha uma view chamada "Error"
        //    }
        //}


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



