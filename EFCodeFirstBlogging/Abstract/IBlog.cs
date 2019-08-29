using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFCodeFirstBlogging.Models;

namespace EFCodeFirstBlogging.Abstract
{
    public interface IBlog
    {
        IQueryable<Blog> Blogs { get; }
    }
}
