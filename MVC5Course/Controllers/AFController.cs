using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class AFController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MadeMeError()
        {
            throw new Exception("不OK");
            return View();
        }
    }
}