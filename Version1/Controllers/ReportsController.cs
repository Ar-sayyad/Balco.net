using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Version1.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult Index()
        {
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Reports >> Daily Perf Reports";
                ViewData["path"] = "https://bldb:8090/ReportServer_SSRS/Pages/ReportViewer.aspx?%2fBalco_Power_Report%2fPerformanceReport&rs:Embed=true";
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult Daily()
        {
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Reports >> Daily Perf Reports";
                ViewData["path"] = "https://bldb:8090/ReportServer_SSRS/Pages/ReportViewer.aspx?%2fBalco_Power_Report%2fPerformanceReport&rs:Embed=true";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult RealtimePerf()
        {
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Reports >> Real-Time Perf Reports";
                ViewData["path"] = "https://bldb:8090/ReportServer_SSRS/Pages/ReportViewer.aspx?%2fBalco_Power_Report%2fPerformanceReportSnapshot&rs:Embed=true";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult DailyGeneration() //LINK CHNAGEING FURTHER
        {
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Reports >> Daily Generation Reports";
                ViewData["path"] = "https://bldb:8090/ReportServer_SSRS/Pages/ReportViewer.aspx?%2fBalco_Power_Report%2fPerformanceReportSnapshot&rs:Embed=true";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}