using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Piloto.ContextoBaseDatos
{
    public class RelacionUsuario_Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public Usuario Usuario { get; set; }

        public Rol Rol { get; set; }
    }
}
