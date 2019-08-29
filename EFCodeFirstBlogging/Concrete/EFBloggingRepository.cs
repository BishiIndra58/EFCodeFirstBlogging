using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFCodeFirstBlogging.Abstract;
using EFCodeFirstBlogging.Models;

namespace EFCodeFirstBlogging.Concrete
{
    public class EFBloggingRepository : IBlog
    {
        EFBloggingContext context = new EFBloggingContext();
        public IQueryable<Blog> Blogs
        {
            get { return context.Blog; }
        }
    }
}