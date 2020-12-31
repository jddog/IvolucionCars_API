using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.DTOs
{
    public class DTOCarRequest
    {
        public string Modelo { get; set; }
        public int Anno { get; set; }
        public int Cilindraje { get; set; }
        public string codigoMarca { get; set; }
        public string codigoTipo { get; set; }
    }
}
