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
    public class FacturaController : ControllerBase
    {
        private readonly AmericanCheeseBackendContext context;
        public FacturaController(AmericanCheeseBackendContext context)
        {
            this.context = context;
        }

        // GET: api/<EmpleadoController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.Factura.ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        // GET api/<EmpleadoController>/5
        [HttpGet("{id}", Name = "GetFactura")]
        public ActionResult Get(int id)
        {
            try
            {
                var SeleccionarFactura = context.Factura.FirstOrDefault(g => g.IdFactura == id);
                return Ok(SeleccionarFactura);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public ActionResult Post([FromBody] Factura NewFactura)
        {
            try
            {
                context.Factura.Add(NewFactura);
                context.SaveChanges();
                return CreatedAtRoute("GetFactura", new { id = NewFactura.IdFactura }, NewFactura);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Factura NewFactura)
        {
            try
            {
                if (NewFactura.IdFactura == id)
                {
                    context.Entry(NewFactura).State = EntityState.Modified;
                    context.SaveChanges();
                    return CreatedAtRoute("GetFactura", new { id = NewFactura.IdFactura }, NewFactura);
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
                var EliminarFactura = context.Factura.FirstOrDefault(g => g.IdFactura == id);

                if (EliminarFactura != null)
                {
                    context.Factura.Remove(EliminarFactura);
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
