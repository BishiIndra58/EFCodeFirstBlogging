using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFCodeFirstBlogging.Abstract;

namespace EFCodeFirstBlogging.Controllers
{
    public class BlogController : Controller
    {
        IBlog iblog;
        public BlogController(IBlog EFBloggingRepositoryObj)
        {
            iblog = EFBloggingRepositoryObj;
        }

        public ActionResult Index()
        {
            return View(iblog.Blogs);
        }

    }
}
