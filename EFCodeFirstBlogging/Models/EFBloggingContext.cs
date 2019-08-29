using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.EntityModel;

namespace EFCodeFirstBlogging.Models
{
    public class EFBloggingContext : DbContext 
    {
        public EFBloggingContext()
            : base("name=BloggingContext")
        {

        }

        public DbSet<Blog> Blog { get; set; }
        public DbSet<Post> Post { get; set; }
    }
}