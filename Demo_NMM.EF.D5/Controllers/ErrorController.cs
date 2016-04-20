﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_NMM.EF.D2.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return RedirectToAction("AccessDenied");
        }

        public ActionResult AccessDenied()
        {
            return View();
        }
    }
}