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
    }
}