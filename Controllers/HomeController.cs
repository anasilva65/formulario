using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using formulario.Models;
using Microsoft.AspNetCore.Http;

namespace formulario.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Cadastro(CadastroModel resposta)
        {
            try
            {
                return RedirectToAction("Obrigado");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public IActionResult Obrigado()
        {
            return View();
        }
    }
}
