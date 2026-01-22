using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class BufferedStreams
    {
        const int BufferSize = 4096; // 4 KB

        static void Main(String[] args)
        {
            Console.Write("Enter source file path: ");
            string sourceFile = Console.ReadLine();

            Console.Write("Enter destination file for unbuffered copy: ");
            string destUnbuffered = Console.ReadLine();

            Console.Write("Enter destination file for buffered copy: ");
            string destBuffered = Console.ReadLine();

            // Copy file without using buffer and measure time
            Stopwatch sw1 = Stopwatch.StartNew();
            CopyWithoutBuffer(sourceFile, destUnbuffered);
            sw1.Stop();
            Console.WriteLine($"Unbuffered copy time: {sw1.ElapsedMilliseconds} ms");

            // Copy file using buffer and measure time
            Stopwatch sw2 = Stopwatch.StartNew();
            CopyWithBuffer(sourceFile, destBuffered);
            sw2.Stop();
            Console.WriteLine($"Buffered copy time: {sw2.ElapsedMilliseconds} ms");
        }

        // Normal FileStream (Unbuffered) - Method to copy file without buffering
        static void CopyWithoutBuffer(string source, string dest)
        {
            // Open source file for reading
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            // Create destination file for writing
            using (FileStream fsWrite = new FileStream(dest, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[BufferSize];   // Create byte buffer
                int bytesRead;

                // Read and write data until file ends
                while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsWrite.Write(buffer, 0, bytesRead);
                }
            }
        }

        // BufferedStream (Buffered) - Method to copy file using buffered streams
        static void CopyWithBuffer(string source, string dest)
        {
            // Open source file and wrap it in a buffered stream
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (BufferedStream bsRead = new BufferedStream(fsRead, BufferSize))

            // Create destination file and wrap it in a buffered stream
            using (FileStream fsWrite = new FileStream(dest, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite, BufferSize))
            {
                byte[] buffer = new byte[BufferSize];
                int bytesRead;

                // Read and write data using buffered streams
                while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bsWrite.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}
