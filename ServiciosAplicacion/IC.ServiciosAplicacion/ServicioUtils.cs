using IC.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.ServiciosAplicacion
{
    public class ServicioUtils 
    {
        public string ObtenerHoraActual()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString("dd-MM-yyyy hh:mm:ss");
        }

        public decimal ObtenerResultadoDivision(DTODivisionRequest dtoDivisionRequest)
        {
            return dtoDivisionRequest.primerNumero / dtoDivisionRequest.segundoNumero;
        }
    }
}
