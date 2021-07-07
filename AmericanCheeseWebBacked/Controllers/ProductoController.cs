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
    public class ProductoController : ControllerBase
    {
        private readonly AmericanCheeseBackendContext context;
        public ProductoController(AmericanCheeseBackendContext context)
        {
            this.context = context;
        }
        // GET: api/<ProductoController>
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Producto.ToList());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        // GET api/<ProductoController>/5
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpGet("{id}", Name = "GetProducto")]
        public ActionResult Get(int id)
        {
            try
            {
                var SeleccionarProducto = context.Producto.FirstOrDefault(g => g.IdProducto == id);
                return Ok(SeleccionarProducto);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // POST api/<ProductoController>
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpPost]
        public ActionResult Post([FromBody] Producto newProducto)
        {
            Producto nuevo = new Producto();
            
            using (var dbTransContext= context.Database.BeginTransaction()) {
                try
                {
                    
                    nuevo.IdCategoria = newProducto.IdCategoria;
                    nuevo.Nombre = newProducto.Nombre;
                    nuevo.Tamaño = newProducto.Tamaño;
                    nuevo.Precio = newProducto.Precio;
                    nuevo.Imagen = newProducto.Imagen;

                    foreach (var item in newProducto.CrearProducto)
                    {
                        Ingredientes ingrediente = context.Ingredientes.FirstOrDefault(g => g.IdIngrediente == item.IdIngrediente);
                        if (ingrediente==null){

                                throw new Exception();
                            }
                        CrearProducto crearProducto = new CrearProducto();

                        crearProducto.IdProducto = context.Producto.LastOrDefault().IdProducto+1;
                        crearProducto.IdIngrediente = ingrediente.IdIngrediente;
                        crearProducto.CantidadIngrediente = item.CantidadIngrediente;
                        crearProducto.PrecioIngrediente = item.PrecioIngrediente;
                        context.CrearProducto.Add(crearProducto);
                    }

                    context.Producto.Add(nuevo);
                    context.SaveChanges();
                    dbTransContext.Commit();
                    
                    return CreatedAtRoute("GetProducto", new { id = newProducto.IdProducto }, newProducto);
                }
                catch (Exception e)
                {
                    dbTransContext.Rollback();
                    return BadRequest(e.Message);
                }
            }
           
        }

        // PUT api/<ProductoController>/5
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Producto newProducto)
        {
            try
            {
                if (newProducto.IdProducto == id)
                {
                    context.Entry(newProducto).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetProducto", new { id = newProducto.IdProducto }, newProducto);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // DELETE api/<ProductoController>/5
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var EliminarProducto = context.Producto.FirstOrDefault(g => g.IdProducto == id);

                if (EliminarProducto != null)
                {
                    context.Producto.Remove(EliminarProducto);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
