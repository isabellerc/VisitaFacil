using Microsoft.AspNetCore.Mvc;

namespace VisitaFacil.WebApp.Controllers
{
    public class FuncionarioController : Controller
    {
        private Contexto db = new Contexto();

        public IActionResult Index()
        {
            var resultado = db.Funcionario
                .ToList();

            return View(resultado);
        }

        public IActionResult Inserir()
        {
            var ent = new Funcionario();
            return View(ent);
        }

        [HttpPost]
        public IActionResult InserirConfirmar(Funcionario ent)
        {
            db.Funcionario.Add(ent);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Excluir(int funcionarioId)
        {
            var objeto = db
                .Funcionario
                .First(f => f.FuncionarioID == funcionarioId);

            db.Funcionario.Remove(objeto);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
