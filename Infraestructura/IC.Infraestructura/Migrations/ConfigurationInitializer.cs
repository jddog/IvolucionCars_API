namespace IC.Infraestructura.Migrations
{
    using IC.Infraestructura.Modelos;
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public class ConfigurationInitializer : IDatabaseInitializer<IC.Infraestructura.BD.Context.ConfigurationBdIvolucionCars>
    {
        public void InitializeDatabase(IC.Infraestructura.BD.Context.ConfigurationBdIvolucionCars context)
        {
            var configuration = new Configuration
            {
                TargetDatabase = new DbConnectionInfo(context.Database.Connection.ConnectionString, "System.Data.SqlClient")
            };

            var migrator = new DbMigrator(configuration);
            if (migrator.GetPendingMigrations().Any())
            {
                migrator.Update();
            }

            executeSeed(context);
        }

        public void executeSeed(IC.Infraestructura.BD.Context.ConfigurationBdIvolucionCars context)
        {
            if(context.Marcas.Count() == 0 && context.TiposVehiculos.Count() == 0)
            {
                context.Marcas.AddOrUpdate(
                    new Marca { Codigo = "CHEV", Nombre = "Chevrolet" },
                    new Marca { Codigo = "MAZD", Nombre = "Mazda" },
                    new Marca { Codigo = "AUDI", Nombre = "Audi" }
                );

                context.TiposVehiculos.AddOrUpdate(
                    new TiposVehiculo { Codigo = "VEHI", Nombre = "Vehiculo", Descripcion = "Vehiculo" },
                    new TiposVehiculo { Codigo = "TRAC", Nombre = "Tractomula", Descripcion = "Tractomula" }
                );
                context.SaveChanges();
            } 
        }
    }
}
