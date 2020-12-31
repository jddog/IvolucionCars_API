namespace IC.Infraestructura.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehiculos")]
    public partial class Vehiculo
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Modelo { get; set; }

        public int Anno { get; set; }

        public int Cilindraje { get; set; }

        [Required]
        [StringLength(4)]
        public string codigoMarca { get; set; }

        [Required]
        [StringLength(4)]
        public string codigoTipo { get; set; }

        public virtual Marca Marca { get; set; }

        public virtual TiposVehiculo TiposVehiculo { get; set; }
    }
}
