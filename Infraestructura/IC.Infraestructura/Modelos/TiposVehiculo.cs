namespace IC.Infraestructura.Modelos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TiposVehiculo")]
    public partial class TiposVehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TiposVehiculo()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(4)]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
