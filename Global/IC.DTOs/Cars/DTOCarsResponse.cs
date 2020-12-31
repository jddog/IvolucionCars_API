using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.DTOs
{
    public class DTOCarsResponse
    {
        public string Modelo { get; set; }
        public int Anno { get; set; }
        public int Cilindraje { get; set; }
        public string marca { get; set; }
        public string tipoVehiculoNombre { get; set; }
        public string tipoVehiculoDescripcion { get; set; }
    }
}
