using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreMvcPlayground.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View(DateTime.Now);
        }
    }
}