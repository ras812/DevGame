using System;
using System.Collections.Generic;
using System.IO;

namespace WellcomeToLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filesPath = @"/Users/Aleks/Projects/DevGame/WellcomeToLinq/Chesterton";
            //string[] files = Directory.GetFiles(filesPath);
            //List<string> linesList = new List<string>();

            //foreach (var item in files)
            //{
            //    string[] lines = File.ReadAllLines(item);
            //    linesList.AddRange(lines);
            //}

            //List<string> wordsList = new List<string>();

            //char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

            //foreach (var item in linesList)
            //{
            //    // item - string

            //    string[] sub = item.Split(delimiterChars,
            //                              StringSplitOptions.RemoveEmptyEntries);

            //    foreach (var s in sub)
            //    {
            //        s.Trim();
            //    }

            //    wordsList.AddRange(sub);
            //}

            //string fileName = @"/Users/Aleks/Projects/DevGame/WellcomeToLinq/out.txt";
            //File.WriteAllLines(fileName, wordsList);
            //Console.WriteLine("Write complete");

            int charMin = char.MinValue;
            int charMax = char.MaxValue;

            //List<char> chars = new List<char>();
            List<char> separators = new List<char>();
            List<char> punctuations = new List<char>();
            List<char> whitespaces = new List<char>();
            List<char> controls = new List<char>();
            List<char> symbols = new List<char>();


            for (int i = charMin; i <= charMax; i++)
            {
                int num = i;
                char c = (char)num;
                if (char.IsSeparator(c))
                {
                    separators.Add(c);
                }
                else if (char.IsPunctuation(c))
                {
                    punctuations.Add(c);
                }
                else if (char.IsWhiteSpace(c))
                {
                    whitespaces.Add(c);
                }
                else if (char.IsControl(c))
                {
                    controls.Add(c);
                }
                else if (char.IsSymbol(c))
                {
                    symbols.Add(c);
                }

            }

            Console.WriteLine("Separators");
            foreach (var item in separators)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("Punctuations");
            foreach (var item in punctuations)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("WhiteSpace");
            foreach (var item in whitespaces)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("Controls");
            foreach (var item in controls)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("Symbols");
            foreach (var item in symbols)
            {
                Console.WriteLine(item);
            }
            //
            //string s = "You win some. You lose some.";
            //char[] separators = new char[] { ' ', '.' };
            //char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            //string[] subs = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

