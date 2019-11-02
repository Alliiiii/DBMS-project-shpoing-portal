using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using System.IO;

namespace WebApplication3.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        abc c = new abc();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login l)
        {
            var x = c.Logins.FirstOrDefault(a => a.Email.Equals(l.Email) && a.Password.Equals(l.Password));
            if (x!=null)
            {
                //ViewBag.m = "Login sucessfully";
                return View("deshBoard");
            }
            else
            {
                ViewBag.e="Invalid username or password";
                return View("Index");
            }
            
        }


        public ActionResult Reg()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Reg(Login l)
        {
            c.Logins.Add(l);
            c.SaveChanges();
            return View("index ");
        }


        public ActionResult AddPkg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPkg(Pkg p, string Offers, HttpPostedFileBase image)
        {
            string pic = Path.Combine(Server.MapPath("~/Images"), image.FileName);
            image.SaveAs(pic);
            var pkg = c.Packages.Where(e => e.Offer == Offers);
            p.Image = pic;
            p.Offer = Offers;
            c.Packages.Add(p);
            c.SaveChanges();
            ViewBag.pk = "Package added successfully";
            return View();
        }

    }
}