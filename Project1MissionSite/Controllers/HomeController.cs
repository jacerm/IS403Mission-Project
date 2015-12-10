using Project1MissionSite.DAL;
using Project1MissionSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Project1MissionSite.Controllers
{
	public class HomeController : Controller
	{
		private MissionSiteContext db = new MissionSiteContext();

		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			return View();
		}

		public ActionResult Contact()
		{
			return View();
		}
		
		[Authorize]
		public ActionResult Mission()
		{
			return View(db.Missions.ToList());
		}

		public ActionResult Login()
		{
			return View();
		}

		//Action method for custome Login to check an email against the user table
		[HttpPost]
		public ActionResult Login(FormCollection form, bool rememberMe = false)
		{
			String email = form["Email"].ToString();
			String password = form["Password"].ToString();

			var currentUser = db.Users.Find(email);
			//if the user does not exist it sends to a creation error page
			if (currentUser == null) 
			{
				return Redirect("~/Home/Error");
			}
			//if the email or password is incorrect it will send you to the incorrect information error page
			if (!(currentUser.userEmail == email) || !(currentUser.userPassword == password))
			{
				return Redirect("~/Home/Error1");
			}
			else 
			{
				FormsAuthentication.SetAuthCookie(email, rememberMe);

				return RedirectToAction("Index", "Home");

			}
		}

		public ActionResult Error()
		{
			return View();
		}

		public ActionResult Error1() 
		{
			return View();
		}

		//sql executable that joins missionquestion and mission together to give the one view access to all needed info
		[Authorize]
        public ActionResult MissionSelection(int missions)
        {
			ViewBag.missions = missions;
			IEnumerable<Data> data =

				db.Database.SqlQuery<Data>(

			"Select * " +

			"FROM missionquestion JOIN mission ON missionquestion.missionId = mission.missionId " +

			"WHERE missionquestion.missionId = " + missions);

			return View(data);
        }
	}
}