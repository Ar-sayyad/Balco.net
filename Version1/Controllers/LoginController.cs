using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Version1.Models;
namespace Version1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            CheckCache();
            if (Session["UserType"] != null)
            {
                return Redirect("Home");
            }
            else
            {
                ViewData["Title"] = "Login";
                return View();
            }
        }

        [HttpPost]
        public ActionResult Index(User user)
        {

            User objUser = new User();
            User returnedUser = objUser.Login(user);
            //New Code
            //User returnedUser = new User();
            //returnedUser.UserName = "Ashif";
            //returnedUser.FirstName = "Ashif";
            //returnedUser.LastName = "Sayyad";
            //returnedUser.Id = 1;
            //returnedUser.UserType = "1";
            //End New Code
            if (returnedUser != null)
            {
                Session["UserName"] = returnedUser.UserName;
                Session["Id"] = Convert.ToString(returnedUser.Id);
                Session["FullName"] = returnedUser.FirstName + " " + returnedUser.LastName;
                Session["UserType"] = returnedUser.UserType;
                return Content("1");
            }
            else
            {
                return Content("Invalid Login Details.");
            }
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }
        public void CheckCache()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
            Response.Cache.SetNoStore();
        }

    }
}