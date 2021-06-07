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
    public class IngredientesController : ControllerBase
    {
        private readonly AmericanCheeseBackendContext context;
        public IngredientesController(AmericanCheeseBackendContext context)
        {
            this.context = context;
        }

        // GET: api/<EmpleadoController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Ingredientes.ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        // GET api/<EmpleadoController>/5
        [HttpGet("{id}", Name = "GetIngredientes")]
        public ActionResult Get(int id)
        {
            try
            {
                var SeleccionarIngredientes = context.Ingredientes.FirstOrDefault(g => g.IdIngrediente == id);
                return Ok(SeleccionarIngredientes);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public ActionResult Post([FromBody] Ingredientes NewIngredientes)
        {
            try
            {
                context.Ingredientes.Add(NewIngredientes);
                context.SaveChanges();
                return CreatedAtRoute("GetIngredientes", new { id = NewIngredientes.IdIngrediente }, NewIngredientes);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Ingredientes NewIngredientes)
        {
            try
            {
                if (NewIngredientes.IdIngrediente == id)
                {
                    context.Entry(NewIngredientes).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetIngredientes", new { id = NewIngredientes.IdIngrediente }, NewIngredientes);
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
                var EliminarIngredientes = context.Ingredientes.FirstOrDefault(g => g.IdIngrediente == id);

                if (EliminarIngredientes != null)
                {
                    context.Ingredientes.Remove(EliminarIngredientes);
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
