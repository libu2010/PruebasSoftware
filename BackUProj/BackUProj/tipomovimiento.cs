//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackUProj
{
    using System;
    using System.Collections.Generic;
    
    public partial class tipomovimiento
    {
        public tipomovimiento()
        {
            this.movimiento = new HashSet<movimiento>();
        }
    
        public int idTipoMovimiento { get; set; }
        public string nombreMovimiento { get; set; }
        public string descripcionMovimiento { get; set; }
    
        public virtual ICollection<movimiento> movimiento { get; set; }
    }
}
