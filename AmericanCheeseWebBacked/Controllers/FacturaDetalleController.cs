using AmericanCheeseWebBacked.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmericanCheeseWebBacked.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaDetalleController : ControllerBase
    {
        private readonly AmericanCheeseBackendContext context;
        public FacturaDetalleController(AmericanCheeseBackendContext context)
        {
            this.context = context;
        }

        // GET: api/<EmpleadoController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.FacturaDetalle.ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        // GET: api/<EmpleadoController>
        [HttpGet("{id}", Name = "GetFacturaDetalle")]
        public ActionResult Get( int id)
        {
            try
            {
                return Ok(context.FacturaDetalle.Where(f=> id==f.IdFactura).ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

    

        // POST api/<EmpleadoController>
        [HttpPost]
        public ActionResult Post([FromBody] FacturaDetalle NewFacturaDetalle)
        {
            try
            {
                context.FacturaDetalle.Add(NewFacturaDetalle);
                context.SaveChanges();
                return CreatedAtRoute("GetFacturaDetalle", NewFacturaDetalle);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    

      
       
    }
}
