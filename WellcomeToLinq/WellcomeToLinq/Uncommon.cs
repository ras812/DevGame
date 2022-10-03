using System;
using System.Collections.Generic;
using System.IO;

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

        public static string[] GetWordsFromFiles(string filesPath)
        {
            string[] fileNames = Directory.GetFiles(filesPath);
            char[] delimiterChars = GetDelimiterChars();
            List<string> resList = new List<string>();

            foreach (var file in fileNames)
            {
                string[] lines = File.ReadAllLines(file);

                foreach (var line in lines)
                {
                    string[] subline = line.Split(delimiterChars,
                                                  StringSplitOptions.RemoveEmptyEntries);

                    foreach (var item in subline)
                    {
                        item.Trim();
                    }

                    resList.AddRange(subline);
                }
            }

            return resList.ToArray();
        }
    }
}

