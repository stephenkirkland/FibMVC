using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FibMVC;

namespace FibMVC.Controllers
{
    public class FibController : Controller
    {
        // GET: Fib
        public ViewResult test()
        {
            ViewData["Fib"] = Biz.CalcFib.Fib();
            return View();
        }
    }
}