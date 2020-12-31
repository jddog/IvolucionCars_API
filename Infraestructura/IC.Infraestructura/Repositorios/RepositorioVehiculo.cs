using IC.Dominio;
using IC.DTOs;
using IC.Infraestructura.BD.Context;
using IC.Infraestructura.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.Infraestructura.Repositorios
{
    public class RepositorioVehiculo
    {
        public IEnumerable<DTOCarsResponse> ObtenerVehiculos()
        {
            ConfigurationBdIvolucionCars configurationBdIvolucionCars = new ConfigurationBdIvolucionCars();
            var query = (from VEH in configurationBdIvolucionCars.Vehiculos
                         join VTIP in configurationBdIvolucionCars.TiposVehiculos on VEH.codigoTipo equals VTIP.Codigo
                         join VMAR in configurationBdIvolucionCars.Marcas on VEH.codigoMarca equals VMAR.Codigo
                         select new DTOCarsResponse()
                         {
                             Modelo = VEH.Modelo,
                             Anno = VEH.Anno,
                             Cilindraje = VEH.Cilindraje,
                             marca = VMAR.Nombre,
                             tipoVehiculoNombre = VTIP.Nombre,
                             tipoVehiculoDescripcion = VTIP.Descripcion
                         });

            return query.ToList();
        }

        public IEnumerable<DTOCarsTipoResponse> ObtenerTiposVehiculos()
        {
            ConfigurationBdIvolucionCars configurationBdIvolucionCars = new ConfigurationBdIvolucionCars();

            var query = (from VTIP in configurationBdIvolucionCars.TiposVehiculos
                         select new DTOCarsTipoResponse()
                         {
                             Id = VTIP.Id,
                             Codigo = VTIP.Codigo,
                             Nombre = VTIP.Nombre,
                             Descripcion = VTIP.Descripcion
                         });

            return query.ToList();
        }

        public IEnumerable<DTOCarsMarcaResponse> ObtenerMarcasVehiculos()
        {
            ConfigurationBdIvolucionCars configurationBdIvolucionCars = new ConfigurationBdIvolucionCars();

            var query = (from VMAR in configurationBdIvolucionCars.Marcas
                         select new DTOCarsMarcaResponse()
                         {
                             Id = VMAR.Id,
                             Codigo = VMAR.Codigo,
                             Nombre = VMAR.Nombre
                         });

            return query.ToList();
        }

        public void RegistrarVehiculo(DominioVehiculo dominioVehiculo)
        {
            ConfigurationBdIvolucionCars configurationBdIvolucionCars = new ConfigurationBdIvolucionCars();
            configurationBdIvolucionCars.Vehiculos.Add(DeDominioAPersistencia(dominioVehiculo));
            configurationBdIvolucionCars.SaveChanges();
        }

        private static Vehiculo DeDominioAPersistencia(DominioVehiculo v)
        {
            return new Vehiculo()
            {
                Anno = v.Anno,
                Cilindraje = v.Cilindraje,
                codigoMarca = v.codigoMarca,
                codigoTipo = v.codigoTipo,
                Modelo = v.Modelo
            };
        }
    }
}
