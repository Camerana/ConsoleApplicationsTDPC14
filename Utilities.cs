using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14
{
    //classe statica
    public static class Utilities
    {
        //funzione statica
        public static bool StringContainsText(string input, string word)
        {
            return input.Contains(word);
        }
        //funzione statica
        public static int GetStringLength(string input)
        {
            return input.Length;
        }
    }
}
