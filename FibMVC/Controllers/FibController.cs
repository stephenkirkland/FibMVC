using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FibMVC;
using FibMVC.Biz;

namespace FibMVC.Controllers
{
    public class FibController : Controller
    {
        // GET: Fib
        public ViewResult test()
        {
            return View();
        }

        public PartialViewResult fib()
        {
            ViewData["Fib"] = Biz.CalcFib.Fib();
            return PartialView(ViewData["Fib"]);
        }

        //ViewData["FibInput"] = Biz.CalcFib.Fib(s);

        [HttpGet]
        public ViewResult FibInput()
        {
            return View();
        }

        [HttpPost]
        public ViewResult FibInput(CalcFib c)
        {
            ViewData["list"] = Biz.CalcFib.d;
            return View("Results", c);
        }
    }
}