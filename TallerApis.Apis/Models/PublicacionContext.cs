using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TallerApis.Apis.Models
{
    public class PublicacionContext : DbContext
    {
        public PublicacionContext() :base("MiPublicacionConnection")
        {

        }

        public DbSet<Publicacion> Publicacion { get; set; }

    }
}

