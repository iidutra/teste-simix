using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using teste_simix.Models;

namespace teste_simix.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Resultado()
        {
            var numeros = "";
            for (int i = 1; i <= 200; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    numeros += " Z ";
                }
                else if (i % 3 == 0)
                {
                    numeros += " X ";
                }
                else if (i % 5 == 0)
                {
                    numeros += " Y ";
                }
                else
                {
                    numeros += i.ToString()+" ";
                }
            }
            ViewData["Numeros"] = numeros;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
