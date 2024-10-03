namespace Aufgabe_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ihr Jahr: ");
                int jahr = int.Parse(Console.ReadLine());

                if (jahr % 4 == 0 && (jahr % 100 != 0) || (jahr % 400 == 0))
                {
                    Console.WriteLine($"{jahr} ist ein Schaltjahr!");
                }
                else
                {
                    Console.WriteLine($"{jahr} ist kein Schaltjahr!");
                }

                Console.WriteLine();

                

            }
        }
    }
}
