namespace Aufgabe_17
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Net;
    internal class Program
    {

        static void Main(string[] args)
        {

            while (1 == 1)
            {
               
                    string joke = GetJoke();
                    Console.WriteLine();
                    Console.WriteLine($"{joke}\n\nNext Joke? (j/n):");
                    Console.WriteLine();
                    var input = Console.ReadKey();
                    Console.WriteLine();
             
                if (input.Key == ConsoleKey.N)
                {
                    break;
                }else 
                if (input.Key != ConsoleKey.J)
                {
                    Console.WriteLine("Bitte gebe eine gültige Zahl ein");
                }

            }
        }

        internal static string GetJoke()
        {
            WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");

            WebResponse response = request.GetResponse();
            Stream responseStream = response.GetResponseStream();

            if (responseStream != null)
            {
                string jsonResponse = new StreamReader(responseStream).ReadToEnd();

                JArray array = JArray.Parse(jsonResponse);

                return array[0]["text"].ToString();
            }

            return string.Empty;
        }


    }
}
