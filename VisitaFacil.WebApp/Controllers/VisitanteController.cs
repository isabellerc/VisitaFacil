//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using VisitaFacil.Dados;
//using VisitaFacil.Dominio.Entities;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using VisitaFacil.Dados;
using VisitaFacil.Dominio.Entities;
using VisitaFacil.WebApp.Models;

namespace VisitaFacil.WebApp.Controllers
{
    public class VisitanteController : Controller
    {

        private Contexto db = new Contexto();
        public IActionResult Index()
        {
            var resultado = db.Visitante
                .ToList();

            return View(resultado);
        }

        public IActionResult Inserir()
        {
            var ent = new Visitante();
            return View(ent);
        }

        public IActionResult Excluir(int ID)
        {
            var objeto = db
                .Visitante
                .First(f => f.idVisitante == ID);

            db.Visitante.Remove(objeto);
            db.SaveChanges();

            return RedirectToAction("Index");
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
        public IActionResult Post (Visitante ent)
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
                db.Visitante.Add(ent);
                db.SaveChanges();
                return RedirectToAction("Index", "Visitante");
            
        }
        public IActionResult Editar(int id)
        {
            Visitante entidade = db.Visitante.Find(id);
            if (entidade == null)
            {
                return NotFound();
            }
            return View(entidade);
        }

        [HttpPost]
        public IActionResult Editar(Visitante ent)
        {
            if (ModelState.IsValid)
            {
                 db.Entry(ent).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                 db.SaveChanges();
                 return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Erro ao salvar as alterações: ");
            return View(ent);
        }
    }
}
