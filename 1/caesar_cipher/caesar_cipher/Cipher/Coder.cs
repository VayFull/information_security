using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caesar_cipher.Cipher
{
    public static class Coder
    {
        public static string Code(string inputText, List<char> alphabet, int key)
        {
            var result = new StringBuilder();
            foreach (var inputChar in inputText)
            {
                var currentSymbolPosition = alphabet.IndexOf(inputChar);
                var shiftedSymbolPosition = (currentSymbolPosition + key) % alphabet.Count;
                var shiftedSymbol = alphabet[shiftedSymbolPosition];
                result.Append(shiftedSymbol);
            }
            return result.ToString();
        }
    }
}