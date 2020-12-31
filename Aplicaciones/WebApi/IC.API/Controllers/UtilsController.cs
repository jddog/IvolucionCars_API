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
    public class UtilsController : ApiController
    {
        [HttpGet]
        public string ObtenerHoraActual()
        {
            ServicioUtils _servicioUtils = new ServicioUtils();
            return _servicioUtils.ObtenerHoraActual();
        }

        [HttpPost]
        public IHttpActionResult ObtenerResultadoDivision(DTODivisionRequest dtoDivisionRequest)
        {
            if(dtoDivisionRequest.segundoNumero == 0)
            {
                return BadRequest("No es posible realizar una devision entre 0");
            }

            ServicioUtils _servicioUtils = new ServicioUtils();
            return Ok(_servicioUtils.ObtenerResultadoDivision(dtoDivisionRequest));
        }
    }
}
