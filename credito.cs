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
    
    public partial class credito
    {
        public int idcredito { get; set; }
        public string saldorestante { get; set; }
        public int usuariosistema_idusuariosistema { get; set; }
        public int solicitudcredito_idsolicitudcredito { get; set; }
        public int status { get; set; }
    
        public virtual catalogostatus catalogostatus { get; set; }
        public virtual solicitudcredito solicitudcredito { get; set; }
        public virtual usuariosistema usuariosistema { get; set; }
    }
}
