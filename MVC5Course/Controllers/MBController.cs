using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class MBController : BaseController
    {
        public ActionResult Index()
        {
            return View(db.Product.Find(1));
        }

        public ActionResult View1()
        {
            ViewBag.Message1 = "Hello World 1";
            TempData["Message2"] = "Hello World 2";
            Session["Message3"] = "Hello World 3";

            return RedirectToAction("View2");
        }

        public ActionResult View2()
        {
            ViewBag.Message1 = ViewBag.Message1;
            ViewBag.Message2 = TempData["Message2"];
            ViewBag.Message3 = Session["Message3"];

            return View();
        }
    }
}