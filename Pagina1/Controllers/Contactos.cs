using Microsoft.AspNetCore.Mvc;
using Pagina1.Models;
namespace Pagina1.Controllers
{
    public class Contactos : Controller
    {
        List<Datos> datosc = new List<Datos>()
        {
            new Datos()
            {
                Correo="k@upi.edu",Nombre="Karim"
            },
            new Datos()
            {
                Correo="Nadir",Nombre="Nadir"
            },
            new Datos()
            {
                Correo="key@upi.edu",Nombre="Keylin"
            }
        };
        public IActionResult Index()
        {
            return View(datosc);
        }
    }
}
