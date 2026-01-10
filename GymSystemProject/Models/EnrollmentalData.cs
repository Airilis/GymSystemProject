using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystemProject.Models
{
		public class EnrollmentalData
		{
				//данные для работы программы, не нужны для записи в json
				public Form UserForm { get; set; }

				// Абонемент
				public bool MembershipActive { get; set; }
				public DateTime MembershipEndDate { get; set; }


				// Выбор пользователя
				public string Training { get; set; }
				public string Trainer { get; set; }
				public DateTime TrainingDate { get; set; }

				// Пользователь (на будущее: JSON, списки)
				public string UserLogin { get; set; }
		}
}
