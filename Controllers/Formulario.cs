using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TEORIA_PC1.Models;

namespace TEORIA_PC1.Controllers
{
    [Route("[controller]")]
    public class Formulario : Controller
    {
        private readonly ILogger<Formulario> _logger;

        public Formulario(ILogger<Formulario> logger)
        {
            _logger = logger;
        }

    

        [HttpGet]
        public IActionResult Operar()
        {
            return View(new Compra()); 
        }

        [HttpPost]
        public IActionResult Operar(Compra compra)
        {
            if (ModelState.IsValid)
            {
                return View(compra);
            }

            return View(compra);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}