using GymSystemProject.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GymSystemProject.Services
{
		public static class JsonStorage
		{
				private static readonly string filePath = "Data/enrollments.json";

				public static void SaveEnrollment(EnrollmentRecord record)
				{
						List<EnrollmentRecord> records = new List<EnrollmentRecord>();

						// Load existing records if the file exists
						if (File.Exists(filePath))
						{
								string existingJson = File.ReadAllText(filePath);
								records = JsonSerializer.Deserialize<List<EnrollmentRecord>>(existingJson)
																		?? new List<EnrollmentRecord>();
						}

						// Add new record
						records.Add(record);

						// Serialize to JSON with indentation
						string json = JsonSerializer.Serialize(records, new JsonSerializerOptions
						{
								WriteIndented = true
						});

						// Ensure "Data" directory exists
						Directory.CreateDirectory("Data");
						File.WriteAllText(filePath, json);
				}
		}
}
