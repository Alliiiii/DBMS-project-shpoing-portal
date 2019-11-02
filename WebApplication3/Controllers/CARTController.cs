using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class CARTController : Controller
    {
        // GET: CART
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }

    }
}