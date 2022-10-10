using System;
using System.Collections.Generic;

namespace WellcomeToLinq
{
    public class WordsHandlers
    {
        private readonly string[] _words;
        private readonly Dictionary<string, int> _frequentWordsDict;

        public WordsHandlers(string filePath)
        {
            _words = Uncommon.GetWordsFromFiles(filePath);
            _frequentWordsDict = GetFrequentWordsDictionary(_words);
        }

        public string GetLongestWordTraditional()
        {
            int MaxWordLength = 0;
            string res = "";

            foreach (var word in _words)
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
            int superMaxNum = int.MaxValue;

            for (int i = 0; i < 10; i++)
            {
                int max = 0;
                string result = "";

                foreach (var item in _frequentWordsDict)
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
            
            return res.ToArray();
        }

        private Dictionary<string, int> GetFrequentWordsDictionary(string[] words)
        {
            Dictionary<string, int> ResultDict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!ResultDict.ContainsKey(word))
                {
                    ResultDict.Add(word, 1);
                }
                else
                {
                    ResultDict[word]++;
                }
            }

            return ResultDict;
        }

        public Dictionary<string, int> Test_GetFrequentWordsDictionary(string[] words)
        {
            return GetFrequentWordsDictionary(words);
        }
    }
}

