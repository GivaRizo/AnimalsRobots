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
    
    public partial class MetodoPagos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MetodoPagos()
        {
            this.Ventas = new HashSet<Ventas>();
        }
    
        public int id { get; set; }
        public string formaPago { get; set; }
        public string descripcion { get; set; }
        public bool eliminado { get; set; }
        public Nullable<System.DateTime> fechaEliminacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}