using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RunnersFilmMVC.Models;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;

namespace RunnersFilmMVC.Controllers
{
    public class AchievementsController : Controller
    {
        // GET: Achievements
        public ActionResult Index()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());


            string email = "not logged in";

            if (user != null)
            {

                email = user.Email;

            }

            ViewBag.email = email;

            return View();
        }
    }
}