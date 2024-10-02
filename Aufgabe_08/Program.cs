namespace Aufgabe_08
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Ganzzahlige Dezimalzahl (q to Quit)");
            int n = int.Parse(Console.ReadLine());
            string bin = "";

            while (n > 0)
            {
                int rest = n % 2;      
                bin = rest + bin;      
                n = n / 2;             
            }

            Console.WriteLine(bin);

        }
    }
}
