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

        [HandleError(Master = "", ExceptionType = typeof(ExecutionEngineException), View = "Error.ExecutionEngine")]
        public ActionResult MadeMeError(string type)
        {
            if (type == "1")
            {
                throw new ExecutionEngineException("測試錯誤");
            }
            throw new Exception("不OK");
            return View();
        }
    }
}