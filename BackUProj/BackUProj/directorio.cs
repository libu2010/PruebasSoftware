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
    
    public partial class directorio
    {
        public directorio()
        {
            this.archivoes = new HashSet<archivo>();
        }
    
        public int idDirectorio { get; set; }
        public int idConfiguracion { get; set; }
        public string nombre { get; set; }
        public string ruta { get; set; }
        public Nullable<decimal> tamanio { get; set; }
    
        public virtual ICollection<archivo> archivoes { get; set; }
        public virtual configuracion configuracion { get; set; }
    }
}