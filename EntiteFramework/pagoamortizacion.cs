//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysCredito.EntiteFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class pagoamortizacion
    {
        public int idpagoamortizacion { get; set; }
        public string periodo { get; set; }
        public int iva { get; set; }
        public double pagoiva { get; set; }
        public double pago { get; set; }
        public double interes { get; set; }
        public double capital { get; set; }
        public int solicitudcredito_idsolicitudcredito { get; set; }
        public double pagototal { get; set; }
        public byte[] pagado { get; set; }
    
        public virtual solicitudcredito solicitudcredito { get; set; }
    }
}
