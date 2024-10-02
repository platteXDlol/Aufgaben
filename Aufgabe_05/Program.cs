
Console.WriteLine("Wie viel Km möchtest du rennen?");
int input = int.Parse(Console.ReadLine());




    if (input > 42)
    {
        Console.WriteLine("Du bist verrückt!");
    }
    else
    {
        int anzahlRunden = input * 1000 / 400;
        Console.WriteLine("Du musst " + anzahlRunden + " Runden rennen.");
        Console.WriteLine("Bist du bereit?");

        if (Console.ReadLine().ToLower() == "ja")
    {
        int i = 1;

        while (i <= anzahlRunden)
        {
            Console.WriteLine("Du läufst Runde :" + i);
            i++;
        }

        Console.WriteLine("Du hast es geschafft!");
    }
   
}
