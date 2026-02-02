using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON.Basic
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    class JsonObject
    {
        static void Main(string[] args)
        {
            Car car = new Car { Brand = "Toyota", Model = "Camry", Year = 2023 };
            string json = JsonConvert.SerializeObject(car, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
