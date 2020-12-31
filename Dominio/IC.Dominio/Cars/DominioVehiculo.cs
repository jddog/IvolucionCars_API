using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.Dominio
{
    public class DominioVehiculo
    {
        public string Modelo { get; set; }
        public int Anno { get; set; }
        public int Cilindraje { get; set; }
        public string codigoMarca { get; set; }
        public string codigoTipo { get; set; }

        public DominioVehiculo(string Modelo, int Anno, int Cilindraje, string codigoMarca, string codigoTipo)
        {
            this.Modelo = Modelo;
            this.Anno = Anno;
            this.Cilindraje = Cilindraje;
            this.codigoMarca = codigoMarca;
            this.codigoTipo = codigoTipo;
        }

        public bool validarAnnoFuturo()
        {
            if(this.Anno > DateTime.Now.Year)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
