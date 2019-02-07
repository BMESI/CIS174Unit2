using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Unit2A3Mesinovic.Controllers
{
    public class CheckersController : Controller
    {
        // GET: Checkers
        public ActionResult CheckersPage()
        {
            return View();
        }
    }
}