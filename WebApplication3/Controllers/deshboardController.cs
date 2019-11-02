using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class deshboardController : Controller
    {
        // GET: deshboard
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult deshBoard()
        {
            return View();
        }
    }
}