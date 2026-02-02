using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace JSON.Intermediate
{
    internal class JsonXML
    {
        static void Main(string[] args)
        {
            string json = @"{ 'name':'Alice','age':25 }";

            XmlDocument doc = JsonConvert.DeserializeXmlNode(json, "Root");
            Console.WriteLine(doc.OuterXml);
        }
    }
}
