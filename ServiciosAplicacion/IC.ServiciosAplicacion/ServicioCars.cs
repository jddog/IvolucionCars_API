using IC.Dominio;
using IC.DTOs;
using IC.Infraestructura.Modelos;
using IC.Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IC.ServiciosAplicacion
{
    public class ServicioCars
    {
        public IEnumerable<DTOCarsResponse> ObtenerVehiculos()
        {
            RepositorioVehiculo _repositorioVehiculo = new RepositorioVehiculo();

            return _repositorioVehiculo.ObtenerVehiculos();
        }

        public IEnumerable<DTOCarsTipoResponse> ObtenerTiposVehiculos()
        {
            RepositorioVehiculo _repositorioVehiculo = new RepositorioVehiculo();

            return _repositorioVehiculo.ObtenerTiposVehiculos();
        }

        public IEnumerable<DTOCarsMarcaResponse> ObtenerMarcasVehiculos()
        {
            RepositorioVehiculo _repositorioVehiculo = new RepositorioVehiculo();

            return _repositorioVehiculo.ObtenerMarcasVehiculos();
        }

        public string RegistrarVehiculo(DTOCarRequest dtoCarRequest)
        {
            DominioVehiculo _dominioVehiculo = new DominioVehiculo(dtoCarRequest.Modelo, dtoCarRequest.Anno, dtoCarRequest.Cilindraje, dtoCarRequest.codigoMarca, dtoCarRequest.codigoTipo);
            if (!_dominioVehiculo.validarAnnoFuturo())
            {
                return "El año del vehículo debe ser inferior al año actual";
            }
            else
            {
                RepositorioVehiculo _repositorioVehiculo = new RepositorioVehiculo();
                _repositorioVehiculo.RegistrarVehiculo(_dominioVehiculo);

                return "Vehiculo creado correctamente";
            }
        }
    }
}
