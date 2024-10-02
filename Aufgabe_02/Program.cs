Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?");
int tage = int.Parse(Console.ReadLine());

int seconds = tage * 24 * 60 * 60;

if (tage < 32 && tage > 27)
{
    Console.WriteLine("Der Monat hat " + seconds + " Sekunden.");
}
else
{
     Console.WriteLine("Bitte geben Sie einen gültigen Monat ein.");
}

