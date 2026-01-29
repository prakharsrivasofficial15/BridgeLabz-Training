using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BridgelabzTraining.csharp_csv_data_handling
{
    internal class EncryptCsv
    {
        static readonly byte[] Key = Encoding.UTF8.GetBytes("1234567890123456");

        static string Encrypt(string plainText)
        {
            using Aes aes = Aes.Create();
            aes.Key = Key;
            aes.GenerateIV();

            using ICryptoTransform encryptor = aes.CreateEncryptor();

            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] cipherBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

            return $"{Convert.ToBase64String(aes.IV)}:{Convert.ToBase64String(cipherBytes)}";
        }

        static void Main(string[] args)
        {
            using StreamWriter writer = new StreamWriter("secure.csv");

            writer.WriteLine("ID,Name,Salary");

            string id = "1";
            string name = "Prakhar";
            string salary = Encrypt("80000");

            writer.WriteLine($"{id},{name},{salary}");

            Console.WriteLine("Salary encrypted and written to CSV successfully");
        }
    }
}
