using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Version1.Controllers
{
    public class KpisController : Controller
    {
        // GET: Kpis
        HomeController home = new HomeController();
        public ActionResult Index()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {

                ViewData["Title"] = "KPIs >> Overall Plant";
                ViewData["path"] = "OverallPlant";
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
                ViewData["Title"] = "KPIs >> Overall Plant";
                ViewData["path"] = "OverallPlant";
                return View("index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult PlantHead()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "KPIs >> Plant Head";
                ViewData["path"] = "";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult Cop()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "KPIs >> COP";
                ViewData["path"] = "COP";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult CopBreakup()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "KPIs >> COP";
                ViewData["path"] = "COPBreakup";
                return View("Cop");
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