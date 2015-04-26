using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ARController : BaseController
    {
        // GET: AR
        public ActionResult Index(string id)
        {
            //if (id.HasValue)
            //{
            //    if (id.Value == 1)
            //    {
            //        return View("View1");
            //    }
                
            //}

            return View();
        }

        public ActionResult View1()
        {
            return View();
        }

        public ActionResult View2()
        {
            return PartialView();
        }

        public ActionResult File1()
        {
            var data = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/pic1.jpg"));

            return File(data, "image/jpg");
        }

        public ActionResult File2()
        {
            return File(Server.MapPath("~/Content/pic1.jpg"), "image/jpg");
        }

        public ActionResult File3()
        {
            var data = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/pic1.jpg"));

            return File(data, "image/jpg", "艦娘.jpg");
        }

        public ActionResult File4()
        {
            var data = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/bootstrap.css"));

            return File(Server.MapPath("~/Content/bootstrap.css"), "text/plain");
        }

        public ActionResult Json1()
        {
            db.Configuration.LazyLoadingEnabled = false;
            var data = db.Product.Take(10);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Redirect1()
        {
            return RedirectToAction("Json1");
        }

        public ActionResult Redirect2()
        {
            return RedirectToActionPermanent("File4");
        }

        public ActionResult NotFind()
        {
            return HttpNotFound();
        }

        public ActionResult StatusCode()
        {
            return new HttpUnauthorizedResult("測試");
        }

    }
}