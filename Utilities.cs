using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14
{
    public static class Utilities
    {
        public static bool StringContainsText(string input, string word)
        {
            return input.Contains(word);
        }
        public static int GetStringLength(string input)
        {
            return input.Length;
        }
    }
}
