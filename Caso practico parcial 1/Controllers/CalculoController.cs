using Microsoft.AspNetCore.Mvc;
using TuProyecto.Models;

namespace TuProyecto.Controllers
{
    public class CalculoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(double tiempo)
        {
            var modelo = new CalculoModel { Tiempo = tiempo };
            modelo.CalcularCaida();
            modelo.GenerarNumeroAleatorio();
            return View("Resultado", modelo);
        }
    }
}
