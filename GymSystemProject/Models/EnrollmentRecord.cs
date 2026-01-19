using System;

namespace GymSystemProject.Models
{
		public class EnrollmentRecord
		{
				// User info
				public string UserLogin { get; set; }

				// Selected training and trainer
				public string Training { get; set; }
				public string Trainer { get; set; }

				// Date of the training
				public DateTime TrainingDate { get; set; }

				// Membership end date at the moment of booking
				public DateTime MembershipEndDate { get; set; }
		}
}
