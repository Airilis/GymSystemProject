using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystemProject.Models
{
		public class EnrollmentRecord
		{
				public string UserLogin { get; set; }
				public string Training { get; set; }
				public string Trainer { get; set; }
				public DateTime TrainingDate { get; set; }
				public DateTime MembershipEndDate { get; set; }
		}
}

