using MicroservicioWiki.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioWiki.Controllers
{

    [ApiController]
    [Route("articulo")]
    public class ArticuloController : Controller
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listar()
        {
            List<Articulo> articulos = new List<Articulo>
            {
                new Articulo()
                {
                    id = 1,
                    categoria = "Tecnología",
                    titulo = "Nuevo Framework para Java",
                    contenido = "La empresa MiTech logró implementar un nuevo freamework compatible con...",
                    autor = "Juan Perez",
                    fecha = "20/06/2022"
                },
                 new Articulo()
                {
                    id = 2,
                    categoria = "Laboral",
                    titulo = "Nuevos puestos para ML",
                    contenido = "Mercado Libre abrió sus puertas para nuevos postulantes.",
                    autor = "Jimena Gomez",
                    fecha = "20/09/2022"
                }, new Articulo()
                {
                    id = 3,
                    categoria = "Tecnología",
                    titulo = "Aprender Git en simples pasos",
                    contenido = "Git es una herramienta de versionado que nos permite...",
                    autor = "Scarlet Cortes",
                    fecha = "17/10/2022"
                }
            };
            return articulos;
        }

        [HttpPost]
        [Route("agregar")]
        public dynamic agregar(Articulo articulo)
        {
            articulo.id = 4;

            return new
            {
                success = true,
                message = "Se guardó correctamente",
                result = articulo
            };
        }

        //public dynamic modificar()
        //{

        //}


    }
}
