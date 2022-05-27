using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();
                string continent=data[0];   
                string country = data[1];
                string city=data[2];
                if (!cities.ContainsKey(continent))
                {
                    cities.Add(continent, new Dictionary<string, List<string>>());  
                }
                Dictionary<string, List<string>> countries = cities[continent];
                if (!countries.ContainsKey(country))
                    countries.Add(country, new List<string>());
                countries[country].Add(city);   
            }
            foreach (var (continentName, countries) in cities)
            {
                Console.WriteLine(continentName + ":");
                foreach (var (countryName, citiesInCountry) in countries)
                {
                    Console.WriteLine("  " + countryName + " -> " +
                        string.Join(", ", citiesInCountry));
                }
            }
        }
    }
}
