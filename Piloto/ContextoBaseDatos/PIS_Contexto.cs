using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Piloto.ContextoBaseDatos
{
    public class PIS_Contexto : DbContext
    {
        public PIS_Contexto() { }

        public PIS_Contexto(DbContextOptions<PIS_Contexto> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<RelacionUsuario_Rol> RelacionUsuario_Rol { get; set; }
        public DbSet<RelacionRol_Permiso> RelacionRol_Permiso { get; set; }
    }
}
