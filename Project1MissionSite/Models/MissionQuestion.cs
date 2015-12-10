using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project1MissionSite.Models
{
	[Table("MissionQuestion")]
	public class MissionQuestion
	{
		//mission question model with missionquestionid as primary key and also an id from the missionid table and useremail reference
		//to user table
		[Key]
		public int missionquestionId { get; set; }
		public string missionquestionQuestion { get; set; }
		public string missionquestionAnswer { get; set; }
		public int? missionId { get; set; }
		public string userEmail { get; set; }
	}
}