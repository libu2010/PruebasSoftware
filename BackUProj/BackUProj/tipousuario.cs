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
    
    public partial class tipousuario
    {
        public tipousuario()
        {
            this.usuariorepositorios = new HashSet<usuariorepositorio>();
        }
    
        public int idTipoUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string descripcionUsuario { get; set; }
    
        public virtual ICollection<usuariorepositorio> usuariorepositorios { get; set; }
    }
}