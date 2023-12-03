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

        private bool IsRepeatingDigits(string value)
        {
            char firstChar = value[0];
            foreach (char c in value)
            {
                if (c != firstChar)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsDigitsOnly(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        [HttpPost]
        public IActionResult Post(Idoso ent)
        {

            //if (ent.Cpf == null)
            //{
            //    return null; //ValidationResult.Success;
            //}

            //string cpf = ent.Cpf.ToString().Replace(".", "").Replace("-", "");

            //if (!IsDigitsOnly(cpf) || cpf.Length != 11)
            //{
            //    return null; //ValidationResult("O CPF deve conter exatamente 11 dígitos numéricos.");
            //}

            //if (IsRepeatingDigits(cpf))
            //{
            //    return null; //ValidationResult("O CPF não pode ter todos os dígitos iguais.");
            //}

            //int sum = 0;
            //for (int i = 0; i < 9; i++)
            //{
            //    sum += int.Parse(cpf[i].ToString()) * (10 - i);
            //}

            //int remainder = sum % 11;
            //int firstVerifier = remainder < 2 ? 0 : 11 - remainder;

            //if (int.Parse(cpf[9].ToString()) != firstVerifier)
            //{
            //    return null; //ValidationResult("O CPF informado não é válido.");
            //}

            //sum = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    sum += int.Parse(cpf[i].ToString()) * (11 - i);
            //}

            //remainder = sum % 11;
            //int secondVerifier = remainder < 2 ? 0 : 11 - remainder;

            //if (int.Parse(cpf[10].ToString()) != secondVerifier)
            //{
            //    return null; //ValidationResult("O CPF informado não é válido.");
            //}

            //else
            //{
                db.Idoso.Add(ent);
                db.SaveChanges();
                return RedirectToAction("IdosoFormulario", "Home");
            //}
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
            return View(ent);
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