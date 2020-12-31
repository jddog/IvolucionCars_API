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
