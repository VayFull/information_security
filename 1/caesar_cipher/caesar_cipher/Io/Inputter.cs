using System;
using System.IO;

namespace caesar_cipher.Io
{
    public static class Inputter
    {
        public static string ReadTextFromFile(string pathToFile) => File.ReadAllText(pathToFile);

        public static int GetKey()
        {
            Console.WriteLine("Please, write key (only positive numbers)");
            var key = int.Parse(Console.ReadLine() ?? throw new FormatException());
            if (key < 0)
            {
                throw new ArgumentException("Only positive numbers!");
            }

            return key;
        }
    }
}