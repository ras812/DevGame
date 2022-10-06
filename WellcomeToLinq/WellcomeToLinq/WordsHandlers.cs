using System;
using System.Collections.Generic;

namespace WellcomeToLinq
{
    public class WordsHandlers
    {
        public string[] Words { get; private set; }

        public WordsHandlers(string filePath)
        {
            Words = Uncommon.GetWordsFromFiles(filePath);
        }

        public string GetLongestWordTraditional()
        {
            int MaxWordLength = 0;
            string res = "";

            foreach (var word in Words)
            {
                if (word.Length >= MaxWordLength)
                {
                    res = word;
                    MaxWordLength = word.Length;
                }
            }

            return res;
        }

        public string[] TenMostFrequentWordsTraditional()
        {
            List<string> res = new List<string>();
            Dictionary<string, int> FrequentWordDict = new Dictionary<string, int>();
            FrequentWordDict = GetFrequentDictionary();
            //
            int superMaxNum = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                int max = 0;
                string result = "";

                foreach (var item in FrequentWordDict)
                {
                    if (item.Value >= max && item.Value < superMaxNum)
                    {
                        max = item.Value;
                        result = item.Key;
                    }
                }

                superMaxNum = max;
                res.Add(result);
            }
            //
            return res.ToArray();
        }

        private Dictionary<string, int> GetFrequentDictionary()
        {
            Dictionary<string, int> ResDict = new Dictionary<string, int>();

            foreach (var word in Words)
            {
                if (!ResDict.ContainsKey(word))
                {
                    ResDict.Add(word, 1);
                }
                else
                {
                    ResDict[word]++;
                }
            }

            return ResDict;
        }

        public Dictionary<string, int> Test_GetFrequentDictionary(string[] words)
        {
            Dictionary<string, int> ResDict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!ResDict.ContainsKey(word))
                {
                    ResDict.Add(word, 1);
                }
                else
                {
                    ResDict[word]++;
                }
            }

            return ResDict;
        }

    }
}

