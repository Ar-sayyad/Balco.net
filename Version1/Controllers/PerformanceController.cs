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

        /***********1200MW END**************/
    }
}