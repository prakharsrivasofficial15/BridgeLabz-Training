using Newtonsoft.Json.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON.Intermediate
{
    internal class PrintKV
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("data.json");
            JObject obj = JObject.Parse(json);

            foreach (var pair in obj)
                Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
    }
}
