﻿using System;
using System.Collections.Generic;
using System.IO;

namespace WellcomeToLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string filesPath = @"/Users/Aleks/Projects/DevGame/WellcomeToLinq/Chesterton";
            string[] words = Uncommon.GetWordsFromFiles(filesPath);

            string fileName = @"/Users/Aleks/Projects/DevGame/WellcomeToLinq/out.txt";
            File.WriteAllLines(fileName, words);
            Console.WriteLine("Write complete");
        }
    }
}

