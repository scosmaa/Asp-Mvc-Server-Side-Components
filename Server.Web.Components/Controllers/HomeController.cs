using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Server.Web.Components.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new Server.Web.Components.Models.User());
        }

        /// <summary>
        /// Subaction Mode
        /// </summary>
        /// <returns></returns>
        public ActionResult NewUser()
        {
            return PartialView();
        }
    }
}