using Microsoft.AspNetCore.Mvc;

namespace WikiTech.Web.Controllers
{
    public class ArticuloController : Controller
    {
        public IActionResult Listar()
        {
            return View();
        }

        public IActionResult Agregar()
        {
            return View();
        }

        public IActionResult Modificar()
        {
            return View();
        }
    }
}
