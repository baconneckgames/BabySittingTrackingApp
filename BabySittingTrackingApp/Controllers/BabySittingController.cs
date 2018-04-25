using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BabySittingTrackingApp.Controllers
{
    public class BabySittingController : Controller
    {
        // GET: BabySitting
        public ActionResult Index()
        {
            return View();
        }
    }
}