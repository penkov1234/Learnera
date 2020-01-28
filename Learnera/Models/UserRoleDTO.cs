using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learnera.Models
{
	public class UserRoleDTO
	{
        public string chosenEmail { get; set; }
        public string chosenRole { get; set; }
        public List<string> userEmails { get; set; }
        public List<string> roles { get; set; }
	}
}