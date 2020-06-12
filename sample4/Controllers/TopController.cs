using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sample4.Controllers
{
    public class TopController : Controller
    {
        // GET: top
        public ActionResult index()
        {
            ViewData["inptmassage"] = "s#";
            return View();
        }


    }
}