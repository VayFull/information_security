using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace caesar_cipher.Cipher
{
    public static class Decoder
    {
        public static string Decode(string text, List<char> alphabet, int checkKey)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var key = DecodeKey(checkKey);
            stopwatch.Stop();
            Console.WriteLine($"Time to find key: {stopwatch.ElapsedMilliseconds / 1000} seconds, key: {key}");

            var result = new StringBuilder();

            var unshiftedDistance = alphabet.Count - key % alphabet.Count;

            foreach (var inputChar in text)
            {
                var currentSymbolPosition = alphabet.IndexOf(inputChar);
                var shiftedSymbolPosition = (currentSymbolPosition + unshiftedDistance) % alphabet.Count;
                var shiftedSymbol = alphabet[shiftedSymbolPosition];
                result.Append(shiftedSymbol);
            }

            return result.ToString();
        }

        private static int DecodeKey(int key)
        {
            var currentKey = int.MinValue;
            while (key != currentKey)
            {
                currentKey++;
            }

            return currentKey;
        }
    }
}