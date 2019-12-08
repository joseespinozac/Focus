//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysCredito.model.dao
{
    using System;
    using System.Collections.Generic;
    
    public partial class solicitudcredito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public solicitudcredito()
        {
            this.credito = new HashSet<credito>();
            this.documentosolicitud = new HashSet<documentosolicitud>();
            this.pagoamortizacion = new HashSet<pagoamortizacion>();
            this.solicitudhaspolitica = new HashSet<solicitudhaspolitica>();
        }
    
        public int idsolicitudcredito { get; set; }
        public int cliente_idcliente { get; set; }
        public double montoparcialidad { get; set; }
        public System.DateTime fechasolicitud { get; set; }
        public int analista_idusuariosistema { get; set; }
        public int asesor_idusuariosistema { get; set; }
        public double saldorestante { get; set; }
        public double monto { get; set; }
        public int status { get; set; }
        public string FK_condiciones { get; set; }
        public string periodocidad { get; set; }
        public string diaspago { get; set; }
        public Nullable<int> numamortizaciones { get; set; }
        public double montototal { get; set; }
    
        public virtual catalogostatus catalogostatus { get; set; }
        public virtual cliente cliente { get; set; }
        public virtual condiciones condiciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<credito> credito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<documentosolicitud> documentosolicitud { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pagoamortizacion> pagoamortizacion { get; set; }
        public virtual usuariosistema usuariosistema { get; set; }
        public virtual usuariosistema usuariosistema1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solicitudhaspolitica> solicitudhaspolitica { get; set; }
    }
}
