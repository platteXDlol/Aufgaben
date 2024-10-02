
using System;

class Aufgabe_07
{
    static void Main()
    {
      
        for (int i = 1; i <= 30; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                Console.Write($"{i}, ");
            }
        }
    }
}
