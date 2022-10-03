using System;
using System.Collections.Generic;

namespace WellcomeToLinq
{
    public class Uncommon
    {
        public static char[] GetDelimiterChars()
        {
            List<char> charsList = new List<char>();

            int charMin = char.MinValue;
            int charMax = char.MaxValue;

            for (int i = charMin; i <= charMax; i++)
            {
                int num = i;
                char c = (char)num;
                if (char.IsSeparator(c) ||
                    char.IsPunctuation(c) ||
                    char.IsWhiteSpace(c) ||
                    char.IsControl(c) ||
                    char.IsSymbol(c)
                   )
                {
                    charsList.Add(c);
                }
            }

            return charsList.ToArray();
        }

        public static string[] 
    }
}

