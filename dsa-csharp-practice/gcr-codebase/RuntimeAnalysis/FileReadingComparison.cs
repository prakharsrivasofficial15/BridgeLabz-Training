using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_Algorithm_Runtime_Analysis
{
    internal class FileReadingComparison
    {
        static void Main()
        {
            // Change this path to a large test file on your system
            string filePath = @"E:\cshrpProject\BridgelabzTraining\BridgelabzTraining\csharp-Algorithm-Runtime-Analysis\500mb.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            Console.WriteLine("File Reading Performance Test");

            // StreamReader
            Stopwatch swStreamReader = Stopwatch.StartNew();
            ReadUsingStreamReader(filePath);
            swStreamReader.Stop();
            Console.WriteLine("StreamReader Time: " + swStreamReader.ElapsedMilliseconds + " ms");

            // FileStream
            Stopwatch swFileStream = Stopwatch.StartNew();
            ReadUsingFileStream(filePath);
            swFileStream.Stop();
            Console.WriteLine("FileStream Time: " + swFileStream.ElapsedMilliseconds + " ms");
        }

        // Character-based reading 
        static void ReadUsingStreamReader(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.Read() != -1)
                {
                    // Reading character by character
                }
            }
        }

        // Byte-based reading
        static void ReadUsingFileStream(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[8192];
                while (fs.Read(buffer, 0, buffer.Length) > 0)
                {
                    // Reading bytes in chunks
                }
            }
        }
    }
}
