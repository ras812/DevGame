using System;
using System.Collections.Generic;
using System.IO;

namespace WellcomeToLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string filesPath = @"/Users/Aleks/Projects/DevGame/WellcomeToLinq/Chesterton";
            //string[] words = Uncommon.GetWordsFromFiles(filesPath);

            WordsHandlers ah = new WordsHandlers(filesPath);

            //string result = ah.GetLongestWordTraditional();

            //Console.WriteLine(result);

            string[] resultArray = ah.TenMostFrequentWordsTraditional();

            foreach (var item in resultArray)
            {
                Console.WriteLine(item);
            }

            // write result to file
            //string fileName = @"/Users/Aleks/Projects/DevGame/WellcomeToLinq/out.txt";
            //File.WriteAllLines(fileName, result);
            //Console.WriteLine("Write to file [out.txt] complete.");
        }
    }
}

