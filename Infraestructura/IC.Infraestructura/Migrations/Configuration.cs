namespace IC.Infraestructura.Migrations
{
    using IC.Infraestructura.Modelos;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IC.Infraestructura.BD.Context.ConfigurationBdIvolucionCars>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    }

}
