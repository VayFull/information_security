using System;
using System.IO;
using System.Linq;
using caesar_cipher.Cipher;
using caesar_cipher.Io;

namespace caesar_cipher
{
    class Program
    {
        private static string WorkingDirectoryPath;

        static void Main(string[] args)
        {
            WorkingDirectoryPath = Directory.GetCurrentDirectory();
            Code(out var key);
            Decode(key);
        }

        static void Code(out int key)
        {
            var inputText = Inputter.ReadTextFromFile($"{WorkingDirectoryPath}/inputText.txt");

            var inputAlphabet = inputText
                .Distinct()
                .OrderBy(x => x)
                .ToList();

            key = Inputter.GetKey();
            
            var codedResult = Coder.Code(inputText, inputAlphabet, key);
            Outputter.ReadTextToFile(codedResult, $"{WorkingDirectoryPath}/outputText.txt");
        }

        static void Decode(int key)
        {
            var textToDecode = Inputter.ReadTextFromFile($"{WorkingDirectoryPath}/outputText.txt");
            
            var inputAlphabet = textToDecode
                .Distinct()
                .OrderBy(x => x)
                .ToList();
            
            var result = Decoder.Decode(textToDecode, inputAlphabet, key);

            Console.WriteLine($"key: {key}, result: {result}");
        }
    }
}