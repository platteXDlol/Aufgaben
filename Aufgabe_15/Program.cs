namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitKeyEntered = false;

            while (!exitKeyEntered)
            {
                bool solved = false;
                int trys = 1;

                int randomNumber = Random.Shared.Next(2, 101);

                Console.WriteLine("Errate die Zahl zwischen 1 und 100: ");

                while (!solved)
                {
                    if (int.TryParse(Console.ReadLine(), out int guess) && guess <= 100)
                    {
                        if (guess > randomNumber)
                        {
                            Console.WriteLine("Zu gross");
                        }

                        else if (guess < randomNumber)
                        {
                            Console.WriteLine("Zu klein");
                        }
                        else
                        {
                            Console.WriteLine("Korrekt");
                            break;
                        }




                    }
                }
            }
        }
    }
}
