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
                var SeleccionarProducto = (from c in context.Categoria
                                           join pd in context.Producto on c.IdCategoria equals pd.IdCategoria
                                           where c.IdCategoria == id
                                           select new
                                           {
                                               Categoria = c.Nombre,
                                               Producto = pd.Nombre,
                                               Imagen = pd.Imagen,
                                               Precio = pd.Precio,
                                               Tamaño = pd.Tamaño,
                                               Ingrediente= (from cp in context.CrearProducto
                                                             join p in context.Producto on cp.IdProducto equals p.IdProducto
                                                             join i in context.Ingredientes on cp.IdIngrediente equals i.IdIngrediente
                                                             where cp.IdProducto==pd.IdProducto
                                                             select new
                                                             {
                                                                 Ingrediente = i.Nombre,

                                                             }).ToList()
                                           }).ToList();
                return Ok(SeleccionarProducto);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}
