using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace WeatherByZip
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

            Console.WriteLine("Enter your zipcode: ");
            var zipCode = Console.ReadLine();

            var apiCall = $"http://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

            Console.WriteLine();

            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} degrees F in your location.");


        }
    }
}

