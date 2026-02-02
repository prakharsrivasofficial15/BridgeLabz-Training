using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON.Basic
{
    internal class MergeJsonObjects
    {
        static void Main(string[] args)
        {
            JObject obj1 = JObject.Parse(@"{ 'name':'Alice','age':25 }");
            JObject obj2 = JObject.Parse(@"{ 'email':'alice@mail.com','city':'NY' }");

            obj1.Merge(obj2);
            Console.WriteLine(obj1.ToString());
        }
    }
}
