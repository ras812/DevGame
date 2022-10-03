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
            List<string> linesList = new List<string>();

            foreach (var file in fileNames)
            {
                string[] lines = File.ReadAllLines(file);
                linesList.AddRange(lines);
            }

            List<string> wordsList = new List<string>();
            char[] delimiterChars = GetDelimiterChars();

            foreach (var item in linesList)
            {
                string[] sub = item.Split(delimiterChars,
                                          StringSplitOptions.RemoveEmptyEntries);

                foreach (var s in sub)
                {
                    s.Trim();
                }

                wordsList.AddRange(sub);
            }

            return wordsList.ToArray();
        }
    }
}

