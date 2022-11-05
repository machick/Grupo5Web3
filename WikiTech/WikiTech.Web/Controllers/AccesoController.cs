using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WikiTech.Entidades;
using WikiTech.Logica;


namespace WikiTech.Web.Controllers
{
    public class AccesoController : Controller
    {

        public IAccesoServicio _IAccesoServicio;
        
        public AccesoController(IAccesoServicio _accesoServicio)
        {
            _IAccesoServicio = _accesoServicio;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                string tokenString = await _IAccesoServicio.LoginAsync(usuario);
                // variable de sesion guardada en cookie para usarse configure program.cs
                HttpContext.Session.SetString("token", tokenString);
                // para obtener el token usar esto
                // HttpContext.Session.GetString("token");

                return Redirect("/Home/Index");
            }
            else
            {
                return View(usuario);
            }
           
        }

        public IActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _IAccesoServicio.Registrarse(usuario);

                return Redirect("/Home/Index");
            }
            else
            {
            return View(usuario);

            }
        }
    }
}
