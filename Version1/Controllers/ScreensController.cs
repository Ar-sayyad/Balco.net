using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Version1.Controllers
{
    public class ScreensController : Controller
    {
        // GET: Screens
        public ActionResult Index()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> Overall Plant";
                ViewData["path"] = "https://bldb:4440/PIVision/#/";
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
                ViewData["Title"] = "Plant Screen >> Overall Plant";
                ViewData["path"] = "https://bldb:4440/PIVision/#/";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        /******540MW Unit #1***********/
        public ActionResult OnefftBoiler()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/25/540MW_U1_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult OnefftTurbine()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/26/540MW_U1_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult OnefftCondenser()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/29/540MW_U1_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult OnefftAirpreHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > Air PreHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/27/540MW_U1_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult OnefftHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/30/540MW_U1_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult OnefftLPHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/31/540MW_U1_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult OnefftPerformance()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #1 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/33/540MW_U1_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /******540MW Unit #2***********/

        public ActionResult TwofftBoiler()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/78/540MW_U2_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult TwofftTurbine()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/75/540MW_U2_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult TwofftCondenser()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/80/540MW_U2_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult TwofftAirpreHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > Air PreHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/79/540MW_U2_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult TwofftHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/76/540MW_U2_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult TwofftLPHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/93/540MW_U2_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult TwofftPerformance()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #2 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/51/540MW_U2_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /******540MW Unit #3***********/
        public ActionResult ThreefftBoiler()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/83/540MW_U3_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ThreefftTurbine()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/86/540MW_U3_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ThreefftCondenser()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/85/540MW_U3_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ThreefftAirpreHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > Air PreHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/82/540MW_U3_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ThreefftHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/84/540MW_U3_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ThreefftLPHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/81/540MW_U3_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ThreefftPerformance()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #3 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/55/540MW_U3_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /******540MW Unit #4***********/
        public ActionResult FourfftBoiler()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/90/540MW_U4_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult FourfftTurbine()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/87/540MW_U4_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult FourfftCondenser()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/88/540MW_U4_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult FourfftAirpreHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > Air preHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/91/540MW_U4_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult FourfftHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/89/540MW_U4_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult FourfftLPHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/92/540MW_U4_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult FourfftPerformance()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 540 MW > Unit #4 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/59/540MW_U4_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /********1200 MW START***********/


        /******1200MW Unit #1***********/
        public ActionResult OnetwhBoiler()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/34/1200MW_U1_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult OnetwhTurbine()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/17/1200MW_U1_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult OnetwhCondenser()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/28/1200MW_U1_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult OnetwhAirpreHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > Air preHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/20/1200MW_U1_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult OnetwhHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/60/1200MW_U1_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult OnetwhLPHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/22/1200MW_U1_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult OnetwhPerformance()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #1 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/32/1200MW_U1_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        /******1200MW Unit #2***********/
        public ActionResult TwotwhBoiler()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/72/1200MW_U2_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult TwotwhTurbine()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/69/1200MW_U2_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult TwotwhCondenser()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/36/1200MW_U2_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult TwotwhAirpreHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > Air preHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/66/1200MW_U2_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult TwotwhHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/21/1200MW_U2_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult TwotwhLPHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/63/1200MW_U2_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult TwotwhPerformance()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #2 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/38/1200MW_U2_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /******1200MW Unit #3***********/
        public ActionResult ThreetwhBoiler()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/73/1200MW_U3_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ThreetwhTurbine()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/70/1200MW_U3_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ThreetwhCondenser()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/37/1200MW_U3_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ThreetwhAirpreHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > Air preHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/67/1200MW_U3_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ThreetwhHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/61/1200MW_U3_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ThreetwhLPHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/64/1200MW_U3_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult ThreetwhPerformance()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #3 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/40/1200MW_U3_BFPs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        /******1200MW Unit #4***********/
        public ActionResult FourtwhBoiler()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > Boiler";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/74/1200MW_U4_Boiler_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult FourtwhTurbine()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > Turbine";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/71/1200MW_U4_SteamTurbine_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult FourtwhCondenser()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > Condenser";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/42/1200MW_U4_Condenser_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult FourtwhAirpreHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > Air preHeater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/68/1200MW_U4_APHs_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult FourtwhHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > HP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/62/1200MW_U4_HPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult FourtwhLPHeater()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > LP Heater";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/65/1200MW_U4_LPHeaters_Overview";
                return View("Index");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult FourtwhPerformance()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                ViewData["Title"] = "Plant Screen >> 1200 MW > Unit #4 > BFPs";
                ViewData["path"] = "https://bldb:4440/PIVision/#/Displays/41/1200MW_U4_BFPs_Overview";
                return View("Index");
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