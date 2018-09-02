using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Piloto.ContextoBaseDatos
{
    public class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Roles id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }

        //public virtual ICollection<Permiso> Permiso { get; set; }
    }

    public enum Roles
    {
        Todo = 1
    }
}
