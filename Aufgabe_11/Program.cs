using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonale_Linie_zeichnen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lang soll die Linie sein?");
            int lineLength = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= lineLength; i++)
            {
                for (int j = 1; j <= lineLength; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void DrawLine(int length)
        {
            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                RepeatCharacter('*', i);
                Console.Write(" ");
                RepeatCharacter('*', length - i - 1);
                Console.WriteLine();
            }
        }

        static void RepeatCharacter(char character, int number)
        {
            for (int i = 0; i < number; i++)
                Console.Write(character);

        }
    }
}

