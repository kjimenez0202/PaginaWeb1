using Microsoft.AspNetCore.Mvc;
using PaginaWeb1.Models;
using System.Diagnostics;

namespace PaginaWeb1.Controllers
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
        public IActionResult Contactenos() {
            //DatosContacto dc = new DatosContacto();
            //dc.Nombre = "Adriana";
            //dc.Correo = "a@upi.ac.cr";
            //dc.Comentario = "Es muy chiva";
            return View();

        }
        [HttpPost] /*Atributo del metodo, solo es para cuando envio el formulario */
        public IActionResult Contactenos(DatosContacto DC) {
            DC.Comentario = "Comentario generico";
            return View("ContactenosGracias", DC);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}