//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysCredito
{
    using System;
    using System.Collections.Generic;
    
    public partial class condiciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public condiciones()
        {
            this.solicitudcredito = new HashSet<solicitudcredito>();
        }
    
        public string idcondiciones { get; set; }
        public int plazo { get; set; }
        public double tasadeinteres { get; set; }
        public double iva { get; set; }
        public int status { get; set; }
        public double cat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitudcredito> solicitudcredito { get; set; }
    }
}
