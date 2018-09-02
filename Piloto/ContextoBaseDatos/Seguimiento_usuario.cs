using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Piloto.ContextoBaseDatos
{
    public class Seguimiento_usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public virtual Usuario Usuario { get; set; }

        public Accion actividad { get; set; }

    }

    public enum Accion
    {
        Pedir_Reporte = 1,
        Ver_Mapa = 2
    }
}
