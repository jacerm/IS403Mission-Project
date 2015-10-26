using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1MissionSite.Controllers
{
	public class HomeController : Controller
	{
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
		
		public ActionResult Mission()
		{
            return View();
		}

        public ActionResult MissionSelection(int missions)
        {
			if (missions == null) 
			{
				missions = 0;
			}
            if (missions == 0)
            {
                ViewBag.MissionTitle = "Texas Lubbock Mission";
                ViewBag.MissionPrez = "President David Shayne Heap";
                ViewBag.MissionAddress = "6310 114th St, Lubbock, TX 79424";
                ViewBag.MissionLanguage = "English and Spanish";
                ViewBag.MissionClimate = "Hot and Dry";
                ViewBag.MissionReligion = "Baptist";
                ViewBag.Logo = "/Content/images/texas.jpg";
            }
            else if (missions == 1)
            {
                ViewBag.MissionTitle = "Nevada Las Vegas West Mission";
                ViewBag.MissionPrez = "President Michael Brown Ahlander";
                ViewBag.MissionAddress = "4455 Allen Lane, Ste: 140, North Las Vegas, NV 89031";
                ViewBag.MissionLanguage = "English, Spanish and Mandarin Chinese";
                ViewBag.MissionClimate = "Hot and Dry";
                ViewBag.MissionReligion = "Catholic";
                ViewBag.Logo = "/Content/images/nevada.gif";
            }
            else if (missions == 2)
            {
                ViewBag.MissionTitle = "Florida Tampa Mission";
                ViewBag.MissionPrez = "President Mark D.Cusick";
                ViewBag.MissionAddress = "13153 N. Dale Mabry Highway Ste: 109 Tampa, FL 33618";
                ViewBag.MissionLanguage = "English, Spanish and French";
                ViewBag.MissionClimate = "Hot and Humid";
                ViewBag.MissionReligion = "Catholic";
                ViewBag.Logo = "/Content/images/florida.png";
            }
            else if (missions == 3)
            {
                ViewBag.MissionTitle = "Alaska Anchorage Mission";
                ViewBag.MissionPrez = "President Eldon Ray Robinson";
                ViewBag.MissionAddress = "3250 Strawberry Road Anchorage, AK 99502";
                ViewBag.MissionLanguage = "English";
                ViewBag.MissionClimate = "Freezing Cold";
                ViewBag.MissionReligion = "Catholic and Other Christians";
                ViewBag.Logo = "/Content/images/alaska.png";
            }

            return View();
        }
	}
}