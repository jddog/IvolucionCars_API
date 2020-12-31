namespace IC.Infraestructura.BD.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using IC.Infraestructura.Modelos;
    using IC.Infraestructura.Migrations;

    public partial class ConfigurationBdIvolucionCars : DbContext
    {
        public ConfigurationBdIvolucionCars()
            : base("name=ConfigurationBdIvolucionCars")
        {
            Database.SetInitializer(new ConfigurationInitializer());
        }

        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<TiposVehiculo> TiposVehiculos { get; set; }
        public virtual DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Marca>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Marca>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Marca>()
                .HasMany(e => e.Vehiculos)
                .WithRequired(e => e.Marca)
                .HasForeignKey(e => e.codigoMarca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TiposVehiculo>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TiposVehiculo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TiposVehiculo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TiposVehiculo>()
                .HasMany(e => e.Vehiculos)
                .WithRequired(e => e.TiposVehiculo)
                .HasForeignKey(e => e.codigoTipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.Modelo)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.codigoMarca)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.codigoTipo)
                .IsUnicode(false);
        }
    }
}
