//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Conexiones.Animales.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos:ProductosCarritos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.DetallePedidos = new HashSet<DetallePedidos>();
            this.DetalleVentas = new HashSet<DetalleVentas>();
            this.ImagenesProductos = new HashSet<ImagenesProductos>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public short stock { get; set; }
        public short precio { get; set; }
        public string color { get; set; }
        public short tamaño { get; set; }
        public Nullable<bool> promocion { get; set; }
        public int idCategoria { get; set; }
        public bool eliminado { get; set; }
        public Nullable<System.DateTime> fechaEliminacion { get; set; }
    
        public virtual Categorias Categorias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallePedidos> DetallePedidos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleVentas> DetalleVentas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagenesProductos> ImagenesProductos { get; set; }
    }
}
