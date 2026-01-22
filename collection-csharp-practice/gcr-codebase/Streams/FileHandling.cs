using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Streams
{
    class FileHandlingExample
    {
        static void Main(string[] args)
        {
            Console.Write("Enter source file path: ");
            string sourceFile = Console.ReadLine();

            Console.Write("Enter destination file path: ");
            string destinationFile = Console.ReadLine();

            try
            {
                // Check if source file exists
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Source file does not exist.");
                    return;
                }
                // Open source file for reading
                using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))

                // Create destination file for writing
                using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                {
                    int byteData;
                    // Read and write one byte at a time
                    while ((byteData = fsRead.ReadByte()) != -1)
                    {
                        fsWrite.WriteByte((byte)byteData);
                    }
                }

                Console.WriteLine("File copied successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    }
}
