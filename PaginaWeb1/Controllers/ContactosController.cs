using Microsoft.AspNetCore.Mvc;
using PaginaWeb1.Models;
namespace PaginaWeb1.Controllers
{
    public class ContactosController : Controller
    {
        List<DatosContacto> datos = new List<DatosContacto>() {

            new DatosContacto() { Correo="rmonge@ui.edu",
                Nombre="Ricardo" },
            new DatosContacto() { Correo="karim@ui.edu",
                Nombre="Karim" },
            new DatosContacto() { Correo="fabio@ui.edu",
                Nombre="Fabiola" },
        };
        public IActionResult Index()
        {
            return View(datos);
        }
    }
}
