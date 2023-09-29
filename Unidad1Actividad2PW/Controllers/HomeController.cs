using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace Unidad1Actividad2PW.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int valor, string Moneda)
        {
            int Resultado = 0;
            if (Moneda == "USD")
            {
                Resultado = valor / 18;
                return View(Resultado);
            }
            else
            {
                Resultado = valor * 18;
                return View(Resultado);
            }


        }
    }
}
