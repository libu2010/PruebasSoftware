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
    
    public partial class usuariorepositorio
    {
        public usuariorepositorio()
        {
            this.proyecto = new HashSet<proyecto>();
        }
    
        public int idUsuarioRepositorio { get; set; }
        public int idTipoUsuario { get; set; }
        public int idRepositorio { get; set; }
        public int idUsuario { get; set; }
    
        public virtual ICollection<proyecto> proyecto { get; set; }
        public virtual repositorio repositorio { get; set; }
        public virtual tipousuario tipousuario { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
