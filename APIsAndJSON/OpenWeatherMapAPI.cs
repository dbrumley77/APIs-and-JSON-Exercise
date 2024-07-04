using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {

        public static void CurrentWeatherForCity()
        {
            HttpClient client = new HttpClient();
            string apiKey = "5664e07eb43d33c24a434fea399c19af";
            string cityName = "Millville";
            string weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";

            string currentWeatherRespones = client.GetStringAsync(weatherURL).Result;
            JObject weatherObject = JObject.Parse(currentWeatherRespones);
            Console.WriteLine($"{weatherObject["main"]["temp"]} is degress Farhrenheit");
        }

    }





}
