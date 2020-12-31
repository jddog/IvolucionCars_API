using IC.DTOs;
using IC.ServiciosAplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace IC.API.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CarsController : ApiController
    {
        [HttpGet]
        public IHttpActionResult ObtenerVehiculos()
        {
            ServicioCars _servicioCars = new ServicioCars();
            return Ok(_servicioCars.ObtenerVehiculos());
        }

        [HttpGet]
        public IHttpActionResult ObtenerTiposVehiculos()
        {
            ServicioCars _servicioCars = new ServicioCars();
            return Ok(_servicioCars.ObtenerTiposVehiculos());
        }

        [HttpGet]
        public IHttpActionResult ObtenerMarcasVehiculos()
        {
            ServicioCars _servicioCars = new ServicioCars();
            return Ok(_servicioCars.ObtenerMarcasVehiculos());
        }

        [HttpPost]
        public IHttpActionResult RegistrarVehiculo(DTOCarRequest dtoCarRequest)
        {
            ServicioCars _servicioCars = new ServicioCars();
            return Ok(_servicioCars.RegistrarVehiculo(dtoCarRequest));
        }
    }
}
