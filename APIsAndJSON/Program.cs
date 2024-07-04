using System;
using System.Net.Http;
using APIsAndJSON;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Kanye: {quote.Kanye()}");

                Console.WriteLine($"Ron Swanson: {quote.RonSwanson()}");

            }

            Console.WriteLine();
            Console.WriteLine();
            OpenWeatherMapAPI.CurrentWeatherForCity();


        }

        


    }
}