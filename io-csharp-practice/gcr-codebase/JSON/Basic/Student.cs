using System;
using Newtonsoft.Json;

namespace JSON.Basic
{
    internal class Student
    {
        static void Main(string[] args)
        {
            var student = new
            {
                name = "Alice",
                age = 20,
                subjects = new[] { "Math", "Physics", "Chemistry" }
            };

            string json = JsonConvert.SerializeObject(student, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}

