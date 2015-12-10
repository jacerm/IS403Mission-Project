using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project1MissionSite.Models
{
	[Table("Mission")]
	public class Mission
	{
		//mission model with missionid for primary key, and all other required information
		[Key]
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