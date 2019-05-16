using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Version1.Controllers
{
    public class ManualController : Controller
    {
        // GET: Manual
        public ActionResult Index()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Manual Entry >> CPP 540 Coal Analysis";
                ViewData["path"] = "";
                return View("manual_cppfiveFourtyCA");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult CppfiveFourtyCA()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Manual Entry >> CPP 540 Coal Analysis";
                ViewData["path"] = "";
                return View("manual_cppfiveFourtyCA");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult CppfiveFourtyDGR()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Manual Entry >> CPP DGR Manual Entry";
                ViewData["path"] = "";
                return View("manual_cppfiveFourtyDGR");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        /********CPP 540 MW *******/

        /********PP 1200 MW *******/
        public ActionResult pptwelveHCA()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Manual Entry >> PP 1200 Coal Analysis";
                ViewData["path"] = "";
                return View("manual_pptwelveHCA");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ippsixHDGR()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Manual Entry >> IPP 600 DGR Manual Entry";
                ViewData["path"] = "";
                return View("manual_ippsixHDGR");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult cppsixHDGR()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Manual Entry >> CPP 600 DGR Manual Entry";
                ViewData["path"] = "";
                return View("manual_cppsixHDGR");
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