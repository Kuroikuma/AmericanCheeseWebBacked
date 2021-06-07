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
    public class EmpleadoController : ControllerBase
    {
        private readonly AmericanCheeseBackendContext context;
        public EmpleadoController(AmericanCheeseBackendContext context)
        {
            this.context = context;
        }

        // GET: api/<EmpleadoController>
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Empleado.ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        // GET api/<EmpleadoController>/5
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpGet("{id}", Name = "GetEmpleado")]
        public ActionResult Get(int id)
        {
            try
            {
                var SeleccionarEmpleado = context.Empleado.FirstOrDefault(g => g.IdEmpleado == id);
                return Ok(SeleccionarEmpleado);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // POST api/<EmpleadoController>
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpPost]
        public ActionResult Post([FromBody] Empleado NewEmpleado)
        {
            try
            {
                context.Empleado.Add(NewEmpleado);
                context.SaveChanges();
                return CreatedAtRoute("GetEmpleado", new { id = NewEmpleado.IdEmpleado }, NewEmpleado);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // PUT api/<EmpleadoController>/5
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Empleado NewEmpleado)
        {
            try
            {
                if (NewEmpleado.IdEmpleado == id)
                {
                    context.Entry(NewEmpleado).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetEmpleado", new { id = NewEmpleado.IdEmpleado }, NewEmpleado);
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
        [EnableCors("_myAllowSpecificOrigins")]
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var EliminarEmpleado = context.Empleado.FirstOrDefault(g => g.IdEmpleado == id);

                if (EliminarEmpleado != null)
                {
                    context.Empleado.Remove(EliminarEmpleado);
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
