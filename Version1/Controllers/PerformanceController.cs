using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Version1.Controllers
{
    public class PerformanceController : Controller
    {
        // GET: Performance
        public ActionResult Index()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> Overall Plant";
                ViewData["path"] = "";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult OverallPlant()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> Overall Plant";
                ViewData["path"] = "";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /***********540MW START**************/
        public ActionResult UnitOnefft()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > Unit #1";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "Unit1";
                return View("UnitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult UnitTwofft()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > Unit #2";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "Unit2";
                return View("UnitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult UnitThreefft()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > Unit #3";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "Unit3";
                return View("UnitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult UnitFourfft()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > Unit #4";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "Unit4";
                return View("UnitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult BopDcsfft()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > BOP";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "BOP";
                return View("UnitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult Boilerfft()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > Boiler";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "Boiler";
                return View("boilerPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult Turbinefft()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 540 MW > Turbine";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "540MW";
                ViewData["path3"] = "Turbine";
                return View("turbinePerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /***********540MW END**************/

        /***********1200MW START**************/
        public ActionResult UnitOnetwh()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > Unit #1";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "Unit1";
                return View("unitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult UnitTwotwh()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > Unit #2";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "Unit2";
                return View("unitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult UnitThreetwh()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > Unit #3";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "Unit3";
                return View("unitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult UnitFourtwh()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > Unit #4";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "Unit4";
                return View("unitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult BopDcstwh()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > BOP";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "BOP";
                return View("unitPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult Boilertwh()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > Boiler";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "Boiler";
                return View("boilerPerformance");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult Turbinetwh()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Performance >> 1200 MW > Turbine";
                ViewData["path1"] = "PERFORMANCE";
                ViewData["path2"] = "1200MW";
                ViewData["path3"] = "Turbine";
                return View("turbinePerformance");
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

        /***********1200MW END**************/
    }
}