using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FRC.Portal.Web.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Menu()
        {
            return PartialView();
        }

        public ActionResult Logout()
        {
            return RedirectToAction("Menu");
        }
    }
}