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
    public class CategoriaController : ControllerBase
    {

        private readonly AmericanCheeseBackendContext context;
        public CategoriaController(AmericanCheeseBackendContext context)
        {
            this.context = context;
        }

        // GET: api/<EmpleadoController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Categoria.ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        // GET api/<EmpleadoController>/5
        [HttpGet("{id}", Name = "GetCategoria")]
        public ActionResult Get(int id)
        {
            try
            {              
                var SeleccionarCategoria = context.Categoria.FirstOrDefault(g => g.IdCategoria == id);
                return Ok(SeleccionarCategoria);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public ActionResult Post([FromBody] Categoria NewCategoria)
        {
            try
            {
                context.Categoria.Add(NewCategoria);
                context.SaveChanges();
                return CreatedAtRoute("GetCategoria", new { id = NewCategoria.IdCategoria }, NewCategoria);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Categoria NewCategoria)
        {
            try
            {
                if (NewCategoria.IdCategoria == id)
                {
                    context.Entry(NewCategoria).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetCategoria", new { id = NewCategoria.IdCategoria }, NewCategoria);
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
                var EliminarCategoria = context.Categoria.FirstOrDefault(g => g.IdCategoria == id);

                if (EliminarCategoria != null)
                {
                    context.Categoria.Remove(EliminarCategoria);
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
