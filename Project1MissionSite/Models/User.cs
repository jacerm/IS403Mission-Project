using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project1MissionSite.Models
{
	[Table("User")]
	public class User
	{
		//user model using a useremail as the primary key, validation for each attribute for the creation of users
		[Key]
		[Required(ErrorMessage = "An email is required")]
		[DataType(DataType.EmailAddress)]
		[EmailAddress]
		public string userEmail { get; set; }
		[Required(ErrorMessage = "A password is required")]
		[DataType(DataType.Password)]
		public string userPassword { get; set; }
		[Required(ErrorMessage = "A first name is required")]
		public string userFirst { get; set; }
		[Required(ErrorMessage = "A last name is required")]
		public string userLast { get; set; }
	}
}