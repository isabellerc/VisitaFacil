﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using VisitaFacil.WebApp.Models;
using VisitaFacil.Dados;
using VisitaFacil.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace VisitaFacil.WebApp.Controllers
{
    public class AutenticadorController : Controller
    {
        private Contexto db = new Contexto();


        //esse esta certo qq coisa descomentar:
        public async Task<IActionResult> Autenticar(string email, string senha)
        {
            var usuario = await db.DadosPessoais.FirstOrDefaultAsync(u => u.Email == email && u.Senha == senha);

            if (usuario != null)
            {
                // Autenticação bem-sucedida
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, usuario.Email),
                    new Claim(ClaimTypes.UserData, usuario.Senha), // Substitua com o campo de nome real do usuário
                     // Substitua com o campo de email do usuário
                    // Você pode adicionar outras informações do usuário, se necessário
                    //new Claim(ClaimTypes.NameIdentifier, usuario.UsuarioId.ToString())

                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true, // Se deseja manter o usuário logado permanentemente ou até logout
                };

                return RedirectToAction("MostrarTela", "Cadastros"); // Redirecione para a página desejada após o login
            }
            else
            {
                // Falha na autenticação
                ModelState.AddModelError(string.Empty, "Nome de usuário ou senha inválidos.");
                return RedirectToAction("Login", "Home");
            }
        }


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home"); // Redirecione para a página inicial ou outra página após o logout         
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SelecionaTipoUsuario()
        {
            return View();
        }

        

        [HttpGet]
        public IActionResult Erro()
        {
            return View();
        }
    }
}
