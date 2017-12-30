using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using SitecoreMvcPlayground.Repositioris;

namespace SitecoreMvcPlayground.Controllers
{
    public class DriverController : Controller
    {
        public ActionResult Featured()
        {
            var repository = new DriverRepository();
            var driver = repository.GetDriver();
            var driverViewModel = repository.GetDriverViewModel(driver);
            return View(driver);

        }
    }
}