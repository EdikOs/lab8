using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class NewController : Controller
    {
        //
        // GET: /New/
        public ActionResult id()
        {
            ViewBag.report = "продукт по коду";
            return View();
        }

        public ActionResult print()
        {
            ViewBag.report = "печать продукта по коду";
            return View();
        }

        public ActionResult category()
        {
            ViewBag.report = "продукт по категории";
            return View();
        }

        public ActionResult date()
        {
            ViewBag.report = "по дате";
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
	}
}