using System;
using Cryptography.AES;

namespace Cryptography.CClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            try
            {
                string input = "Hello, my name is John Woo";
                string key = "1a25s8fe5dsg65ad";

                Console.WriteLine("Входен текс: " + input);
            
                sbyte[] encr = AESImplementation.encrypt(input.GetBytes(), key.GetBytes());
                Console.WriteLine("Криптиран текст със AES: " + StringHelperClass.NewString(encr));

                sbyte[] decr = AESImplementation.decrypt(encr, key.GetBytes());
                Console.WriteLine("Декриптиран текст със AES: " + StringHelperClass.NewString(decr));
                FileHelper.SaveToFile();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
