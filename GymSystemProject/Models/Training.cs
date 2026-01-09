using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace GymSystemProject.Forms
namespace GymSystemProject.Models
{
		public class Training
		{
				public string Name { get; set; }
				public DateTime Date { get; set; }
				public int MaxParticipants { get; set; }

				public override string ToString()
				{
						return $"{Name} ({Date:dd.MM.yyyy HH:mm})";
				}
		}
}
