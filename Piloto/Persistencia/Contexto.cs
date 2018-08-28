using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace Piloto.Persistencia
{
    public class Contexto : DbContext
    {
        public Contexto() { }

        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Blog> Blogs { get; set; }

        public class Blog
        {
            public int  BlogId { get; set; }
            public string Url { get; set; }

        }

    }   
}
