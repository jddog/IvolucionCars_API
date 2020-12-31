# IvolucionCars_API

Servicio API REST (Back - End) para prueba de Ivolucion


Para utilizar este proyecto se necesita tener las siguientes herramientas:


- Tener instalado Visual Studio
- Tener instalado Sql Server Managment Studio
- Tener instalado GIT para clonar el proyecto

Clonar proyecto:
- Se debe ejecutar el siguiente comando estando en el directorio que se desee obetener el codigo:
```
git clone https://github.com/jddog/IvolucionCars_API.git
```

- Luego ingresar a la carpeta generada y abrir el archivo IvolucionCars.sln para abrir la solucion con Visual Studio

```sh
# Configurar cadena de conexion a la bd de SQL Server
- Abrir el archivo Web.Config que se encuentra en el proyecto Aplicaciones/WebApi/IC.API

- En la linea numero 68 del archivo modificar unicamente el user id (usuario) y password segun el usuario configurado en el equipo.
NOTA: De ser necesario modificar el data source(servidor de SQL)
```
Lanzar Servidor

- Asegurarse que el proyecto Aplicaciones/WebApi/IC.API se encuentre como proyecto inicial, de no ser asi dar click derecho y seleccionar la opcion "Establecer como proyecto de inicio"
- Correr el proyecto con Visual Studio y este automaticamente creara la BD , junto a sus tablas y datos de semilla iniciales
- Verificar en Sql Server Managment Studio, la creacion de la Bd junto a sus tablas

# Metodos del Servicio

- Para consultar la fecha actual, se debe enviar una peticion de tipo GET a la siguiente url

```sh
End point:
https://localhost:44333/api/utils/ObtenerHoraActual

```

- Para dividir dos numeros, se debe enviar una peticion de tipo POST a la siguiente url

```sh
header: {"Content-Type" : "application/json"}

Body: {
	"primerNumero":2,
	 "segundoNumero":"2"
}

End point:
https://localhost:44333/api/utils/ObtenerHoraActual

```

- Para consultar todos los vehiculos, se debe enviar una peticion de tipo GET a la siguiente url

```sh
End point:
https://localhost:44333/api/cars/ObtenerVehiculos

```

- Para consultar los tipos de vehiculos que se crearon con semillas desde el servicio, se debe enviar una peticion de tipo GET a la siguiente url

```sh
End point:
https://localhost:44333/api/cars/ObtenerTiposVehiculos

```

- Para consultar las marcas de vehiculos que se crearon con semillas desde el servicio, se debe enviar una peticion de tipo GET a la siguiente url

```sh
End point:
https://localhost:44333/api/cars/ObtenerMarcasVehiculos

```

- Para registrar un vehiculo, se debe enviar una peticion de tipo POST a la siguiente url

```sh
header: {"Content-Type" : "application/json"}

Body: {
	"Modelo" : "Sail",
	"Anno" : 2017,
	"Cilindraje" : 2,
	"codigoMarca" : "AUDI",
	"codigoTipo" : "VEHI"
}

End point:
https://localhost:44333/api/cars/RegistrarVehiculo

```
