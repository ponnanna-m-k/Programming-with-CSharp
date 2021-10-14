using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Serialization
{
    public class car
    {
        public DateTimeOffset Date { get; set; }
        public int Year{ get; set; }
        public string Name { get; set; }
    }
    class Serialize
    {
        static void Main(string[] args)
        {
            var car = new car
            {
                Date = DateTime.Parse("2021-01-02"),
                Year = 2009,
                Name = "Honda City"
            };

            string carString = JsonSerializer.Serialize(car);
            Console.WriteLine("Details of my car in json {0}", carString);
        }
    }
}
