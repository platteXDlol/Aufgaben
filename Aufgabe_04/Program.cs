
Console.WriteLine("Zahl von 1 bis 12 :");
int zahl = int.Parse(Console.ReadLine());

string[] a = { "Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "November", "Dezember" };

if (zahl > 0 && zahl < 13)
{
    Console.WriteLine("Der Monat ist " + a[--zahl]);
}
else
{
    Console.WriteLine("Bitte geben Sie eine gültige Zahl ein.");
}