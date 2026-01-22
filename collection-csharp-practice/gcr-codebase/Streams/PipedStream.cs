using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class PipedStream
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a pipe server that can only send data
                using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out))

                // Create a pipe client that can only receive data
                using (AnonymousPipeClientStream pipeClient =
                    new AnonymousPipeClientStream(PipeDirection.In, pipeServer.ClientSafePipeHandle))
                {
                    // Create a thread to write data into the pipe
                    Thread writerThread = new Thread(() => WriteData(pipeServer));
                    // Create a thread to read data from the pipe
                    Thread readerThread = new Thread(() => ReadData(pipeClient));

                    // Start both threads
                    writerThread.Start();
                    readerThread.Start();

                    // Wait for both threads to finish
                    writerThread.Join();
                    readerThread.Join();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
        // This method writes messages into the pipe
        static void WriteData(Stream pipe)
        {
            using (StreamWriter writer = new StreamWriter(pipe, Encoding.UTF8) { AutoFlush = true })
            {
                for (int i = 1; i <= 5; i++)
                {
                    writer.WriteLine($"Message {i}");
                    // Wait half a second before sending the next message
                    Thread.Sleep(500); // simulate work
                }
            }
        }

        static void ReadData(Stream pipe)
        {
            // Create a reader to receive text data
            using (StreamReader reader = new StreamReader(pipe, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine("Received: " + line);
                }
            }
        }
    }
}
