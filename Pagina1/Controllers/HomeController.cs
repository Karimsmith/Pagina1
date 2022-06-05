using Microsoft.AspNetCore.Mvc;
using Pagina1.Models;
using System.Diagnostics;

namespace Pagina1.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contacto()
        {
            //Datos dc = new Datos();
            //dc.nombre = "Karim Smith";
            //dc.correo = "karimsceba20@hotmail.com";
            //dc.comentario = "Problemas con la pagina";
            return View();
        }
        public IActionResult Ejemplo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contacto(Datos DC)
        {
            DC.Comentario = "Problema con la Pagina";
            return View("ContactenosGracias",DC);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}