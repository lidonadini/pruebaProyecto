using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Piloto.ContextoBaseDatos
{
    public class RelacionRol_Permiso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Permiso Permiso { get; set; }
    }
}
