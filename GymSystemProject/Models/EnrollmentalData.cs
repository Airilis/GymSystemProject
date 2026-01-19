using System;
using GymSystemProject.Forms;

namespace GymSystemProject.Models
{
		public class EnrollmentalData
		{
				// Runtime-only references, not saved to JSON
				public UserForm UserForm { get; set; }
				public LoginPage LoginForm { get; set; }

				// Membership info
				public bool MembershipActive { get; set; }
				public DateTime MembershipEndDate { get; set; }

				// User selections
				public string Training { get; set; }
				public string Trainer { get; set; }
				public DateTime TrainingDate { get; set; }

				// User info (for future: JSON storage, lists)
				public string UserLogin { get; set; }
		}
}
