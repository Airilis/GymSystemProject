import json
from datetime import datetime
from collections import Counter
from pathlib import Path


# ŚCIEŻKI 
BASE_DIR = Path(__file__).resolve().parent.parent
DATA_DIR = BASE_DIR / "data"

CLIENTS_FILE = DATA_DIR / "clients.json"
TRAININGS_FILE = DATA_DIR / "trainings.json"
REPORT_FILE = DATA_DIR / "report.txt"


# MAPA DNI TYGODNIA
WEEKDAY_PL = {
    "Monday": "Poniedziałek",
    "Tuesday": "Wtorek",
    "Wednesday": "Środa",
    "Thursday": "Czwartek",
    "Friday": "Piątek",
    "Saturday": "Sobota",
    "Sunday": "Niedziela"
}


# WCZYTYWANIE
def load_json(path):
    with open(path, "r", encoding="utf-8") as file:
        return json.load(file)


# ANALIZA 
def analyze_data(clients, trainings):
    analysis = {}

    # mapowanie login -> imię
    client_names = {c["login"]: c["name"] for c in clients}
    analysis["client_names"] = client_names

    analysis["clients_count"] = len(clients)
    analysis["trainings_count"] = len(trainings)

    if not trainings:
        return analysis

    durations = [t["durationMinutes"] for t in trainings]
    calories = [t["caloriesBurned"] for t in trainings]

    analysis["avg_duration"] = sum(durations) / len(durations)
    analysis["avg_calories"] = sum(calories) / len(calories)

    training_types = Counter(t["trainingType"] for t in trainings)
    analysis["popular_training"] = training_types.most_common(1)[0]

    weekday_counter = Counter()
    month_counter = Counter()
    user_activity = Counter()

    dates = []

    for t in trainings:
        date = datetime.strptime(t["date"], "%Y-%m-%d")
        dates.append(date)

        weekday_en = date.strftime("%A")
        weekday_pl = WEEKDAY_PL.get(weekday_en, weekday_en)
        month = date.strftime("%B")

        weekday_counter[weekday_pl] += 1
        month_counter[month] += 1
        user_activity[t["clientLogin"]] += 1

    # średnia liczba treningów na tydzień
    first_date = min(dates)
    last_date = max(dates)
    weeks = max(1, (last_date - first_date).days // 7)
    analysis["avg_trainings_per_week"] = len(trainings) / weeks

    analysis["popular_weekday"] = weekday_counter.most_common(1)[0]
    analysis["weekday_activity"] = weekday_counter
    analysis["activity_by_user"] = user_activity
    analysis["activity_by_month"] = month_counter

    return analysis


# RAPORT
def generate_report(analysis):
    lines = []

    lines.append("RAPORT ANALIZY AKTYWNOŚCI KLIENTÓW SIŁOWNI")
    lines.append("=" * 45)
    lines.append(f"Liczba klientów: {analysis['clients_count']}")
    lines.append(f"Liczba treningów: {analysis['trainings_count']}")
    lines.append("")

    if "avg_duration" in analysis:
        lines.append(f"Średnia długość treningu: {analysis['avg_duration']:.1f} min")
        lines.append(f"Średnia liczba spalonych kalorii: {analysis['avg_calories']:.1f} kcal")
        lines.append(
            f"Średnia liczba treningów na tydzień: "
            f"{analysis['avg_trainings_per_week']:.2f}"
        )
        lines.append("")

        training, count = analysis["popular_training"]
        lines.append(f"Najpopularniejszy typ treningu: {training} ({count})")

        weekday, wcount = analysis["popular_weekday"]
        lines.append(f"Najpopularniejszy dzień tygodnia: {weekday} ({wcount})")
        lines.append("")

        lines.append("Najaktywniejsi klienci:")
        for user, cnt in analysis["activity_by_user"].most_common():
            name = analysis["client_names"].get(user, "Nieznany")
            lines.append(f"- {name} ({user}): {cnt} treningów")

        lines.append("")
        lines.append("Aktywność według dni tygodnia:")
        for day, cnt in analysis["weekday_activity"].items():
            lines.append(f"- {day}: {cnt}")

    return "\n".join(lines)


# MAIN
def main():
    clients = load_json(CLIENTS_FILE)
    trainings = load_json(TRAININGS_FILE)

    analysis = analyze_data(clients, trainings)
    report = generate_report(analysis)

    with open(REPORT_FILE, "w", encoding="utf-8") as file:
        file.write(report)

    print("Raport wygenerowany pomyślnie.")


if __name__ == "__main__":
    main()
