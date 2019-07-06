using Orchard.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeSanook.PrivacyPolicy.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Themed]
        public ActionResult Index()
        {
            return View();
        }
    }
}
