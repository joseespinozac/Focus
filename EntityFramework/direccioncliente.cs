//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysCredito.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class direccioncliente
    {
        public int iddireccioncliente { get; set; }
        public string calle { get; set; }
        public string colonia { get; set; }
        public string numexterior { get; set; }
        public string numinterior { get; set; }
        public int cliente_idcliente { get; set; }
        public int municipio_idmunicipio { get; set; }
    
        public virtual cliente cliente { get; set; }
        public virtual municipio municipio { get; set; }
    }
}