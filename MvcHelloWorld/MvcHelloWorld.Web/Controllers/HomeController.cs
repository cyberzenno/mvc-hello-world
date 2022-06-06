using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcHelloWorld.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PageOne()
        {
            return View();
        }

        public ActionResult PageTwo()
        {
            return View();
        }

        public ActionResult PageThree()
        {
            return View();
        }
    }
}