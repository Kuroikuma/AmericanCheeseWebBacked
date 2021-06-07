using AmericanCheeseWebBacked.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmericanCheeseWebBacked.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoCategoriaController : ControllerBase
    {
        private readonly AmericanCheeseBackendContext context;
        public ProductoCategoriaController(AmericanCheeseBackendContext context)
        {
            this.context = context;
        }


        // GET api/<ValuesController>/5
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                //var SeleccionarProducto = context.Producto.Where(s => s.IdCategoria == id).ToList();
                var SeleccionarProducto = context.Categoria.Where(s => s.IdCategoria == id)
                    .Join(
                        context.Producto,
                        Categoria => Categoria.IdCategoria,
                        Producto => Producto.IdCategoriaNavigation.IdCategoria,
                        (Categoria, Producto) => new
                        {
                            Categoria = Categoria.Nombre,
                            Producto = Producto.Nombre,
                            Imagen =Producto.Imagen,
                            Precio=Producto.Precio,
                            Tamaño=Producto.Tamaño

                        }
                    ).ToList();
                return Ok(SeleccionarProducto);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}
