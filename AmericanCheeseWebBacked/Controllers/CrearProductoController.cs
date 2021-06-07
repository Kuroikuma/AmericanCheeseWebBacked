using AmericanCheeseWebBacked.Models;
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
    public class CrearProductoController : ControllerBase
    {

        private readonly AmericanCheeseBackendContext context;
        public CrearProductoController(AmericanCheeseBackendContext context)
        {
            this.context = context;
        }

        // GET: api/<EmpleadoController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.CrearProducto.ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        // GET api/<EmpleadoController>/5
        [HttpGet("{id}", Name = "GetCrearProducto")]
        public ActionResult Get(int id)
        {
            try
            {
                var SeleccionarCrearProducto = context.CrearProducto.FirstOrDefault(g => g.IdCrearProducto == id);
                return Ok(SeleccionarCrearProducto);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public ActionResult Post([FromBody] CrearProducto NewCrearProducto)
        {
            try
            {
                context.CrearProducto.Add(NewCrearProducto);
                context.SaveChanges();
                return CreatedAtRoute("GetCrearProducto", new { id = NewCrearProducto.IdCrearProducto }, NewCrearProducto);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CrearProducto NewCrearProducto)
        {
            try
            {
                if (NewCrearProducto.IdCrearProducto == id)
                {
                    context.Entry(NewCrearProducto).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetCrearProducto", new { id = NewCrearProducto.IdCrearProducto }, NewCrearProducto);
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

        // DELETE api/<EmpleadoController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var EliminarCrearProducto = context.CrearProducto.FirstOrDefault(g => g.IdCrearProducto == id);

                if (EliminarCrearProducto != null)
                {
                    context.CrearProducto.Remove(EliminarCrearProducto);
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
