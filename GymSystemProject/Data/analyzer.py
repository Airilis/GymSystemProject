import os
import json
from collections import Counter
from datetime import datetime

# Dictionary to translate weekdays to Polish (can be adjusted)
DAYS_POLISH = {
    "Monday": "Poniedziałek",
    "Tuesday": "Wtorek",
    "Wednesday": "Środa",
    "Thursday": "Czwartek",
    "Friday": "Piątek",
    "Saturday": "Sobota",
    "Sunday": "Niedziela"
}

class GymAnalyzer:
    def __init__(self):
        self.enrollments_file = self.find_enrollments_file()
        self.report_file = os.path.join(
            os.path.dirname(os.path.abspath(__file__)),
            "report.txt"
        )
        self.enrollments = []

    def find_enrollments_file(self):
        # Search for enrollments.json starting from parent directory
        start_dir = os.path.abspath(os.path.join(os.path.dirname(__file__), ".."))
        for root, dirs, files in os.walk(start_dir):
            if "enrollments.json" in files:
                return os.path.join(root, "enrollments.json")
        return None

    def load_data(self):
        if not self.enrollments_file or not os.path.exists(self.enrollments_file):
            print("File enrollments.json does not exist!")
            return False

        with open(self.enrollments_file, "r", encoding="utf-8") as f:
            self.enrollments = json.load(f)
        return True

    def analyze(self):
        if not self.enrollments:
            print("No data to analyze!")
            return

        total_clients = len(set(e["UserLogin"] for e in self.enrollments))
        total_trainings = len(self.enrollments)

        # Convert training dates to weekday names in Polish
        days = [
            DAYS_POLISH[
                datetime.fromisoformat(e["TrainingDate"]).strftime("%A")
            ]
            for e in self.enrollments
        ]

        day_counts = Counter(days)
        trainings = Counter(e["Training"] for e in self.enrollments)
        clients = Counter(e["UserLogin"] for e in self.enrollments)
        trainers = Counter(e.get("Trainer", "Unknown") for e in self.enrollments)

        self.report_data = {
            "total_clients": total_clients,
            "total_trainings": total_trainings,
            "avg_trainings_per_client": round(total_trainings / total_clients, 2)
            if total_clients else 0,
            "most_popular_days": day_counts.most_common(3),
            "full_week_distribution": day_counts.most_common(),
            "most_popular_trainings": trainings.most_common(3),
            "most_active_clients": clients.most_common(3),
            "report_per_client": dict(clients),
            "month_activity": Counter(
                datetime.fromisoformat(e["TrainingDate"]).strftime("%Y-%m")
                for e in self.enrollments
            ).most_common(),
            "top_trainers": trainers.most_common()
        }

    def save_report(self):
        if not hasattr(self, "report_data"):
            print("No data available for report!")
            return

        lines = []
        lines.append(f"Total clients: {self.report_data['total_clients']}")
        lines.append(f"Total trainings: {self.report_data['total_trainings']}")
        lines.append(
            f"Average trainings per client: {self.report_data['avg_trainings_per_client']}\n"
        )

        lines.append("Most popular weekdays (top 3):")
        for day, count in self.report_data["most_popular_days"]:
            lines.append(f"  {day}: {count}")

        lines.append("\nTop trainings (top 3):")
        for t, count in self.report_data["most_popular_trainings"]:
            lines.append(f"  {t}: {count}")

        lines.append("\nTop trainers:")
        for t, count in self.report_data["top_trainers"]:
            lines.append(f"  {t}: {count}")

        with open(self.report_file, "w", encoding="utf-8") as f:
            f.write("\n".join(lines))

        print(f"Report saved at: {self.report_file}")


if __name__ == "__main__":
    analyzer = GymAnalyzer()
    if analyzer.load_data():
        analyzer.analyze()
        analyzer.save_report()
