using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Version1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Dashboard";
                ViewData["titlebar"] = "Dashboard";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public void CheckCache()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
        }
    }
}