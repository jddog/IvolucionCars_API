namespace IC.Infraestructura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Codigo = c.String(nullable: false, maxLength: 4, unicode: false),
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Vehiculos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Modelo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Anno = c.Int(nullable: false),
                        Cilindraje = c.Int(nullable: false),
                        codigoMarca = c.String(nullable: false, maxLength: 4, unicode: false),
                        codigoTipo = c.String(nullable: false, maxLength: 4, unicode: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TiposVehiculo", t => t.codigoTipo)
                .ForeignKey("dbo.Marcas", t => t.codigoMarca)
                .Index(t => t.codigoMarca)
                .Index(t => t.codigoTipo);
            
            CreateTable(
                "dbo.TiposVehiculo",
                c => new
                    {
                        Codigo = c.String(nullable: false, maxLength: 4, unicode: false),
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripcion = c.String(nullable: false, maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehiculos", "codigoMarca", "dbo.Marcas");
            DropForeignKey("dbo.Vehiculos", "codigoTipo", "dbo.TiposVehiculo");
            DropIndex("dbo.Vehiculos", new[] { "codigoTipo" });
            DropIndex("dbo.Vehiculos", new[] { "codigoMarca" });
            DropTable("dbo.TiposVehiculo");
            DropTable("dbo.Vehiculos");
            DropTable("dbo.Marcas");
        }
    }
}
