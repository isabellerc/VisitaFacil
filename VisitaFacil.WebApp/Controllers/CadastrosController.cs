﻿using Microsoft.AspNetCore.Mvc;
using VisitaFacil.Dados;
using VisitaFacil.Dominio.Entities;
using VisitaFacil.WebApp.Models;

namespace VisitaFacil.WebApp.Controllers
{
    public class CadastrosController : Controller
    {
        public IActionResult MostrarTela()
        {
            return RedirectToAction("Cadastros", "Home");         
        }     
    }
}