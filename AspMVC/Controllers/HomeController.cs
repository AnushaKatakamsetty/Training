using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public JsonResult MyPage()
        { return Json("{id:1;name:n1}"); }
        public ViewResult Mypage2()
        {
            return View();
        }
        public ActionResult MyPage1()
        {
            return Json("{ id:n1,name:n1 }",JsonRequestBehavior.AllowGet);
        }

    }
}