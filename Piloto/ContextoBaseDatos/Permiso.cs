using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Piloto.ContextoBaseDatos
{
    public class Permiso
    {

        public RolesPermisos PermisoID { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        
    }

    public enum RolesPermisos
    {
        Todo = 1
    }
}
