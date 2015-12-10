using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1MissionSite.Models
{
	public class Data
	{
		//model for the joined table used in missionselection view
		[Key]
		public int missionquestionId { get; set; }
		public string missionquestionQuestion { get; set; }
		public string missionquestionAnswer { get; set; }
		public string userEmail { get; set; }
		public int missionId { get; set; }
		public string missionName { get; set; }
		public string missionPresidentFirst { get; set; }
		public string missionAddress { get; set; }
		public string missionLanguage { get; set; }
		public string missionClimate { get; set; }
		public string missionReligion { get; set; }
		public string missionFlag { get; set; }
		public string missionCity { get; set; }
		public string missionState { get; set; }
		public string missionZip { get; set; }
		public string missionPresidentLast { get; set; }
		
	}
}