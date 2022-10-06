using System.Collections.Generic;
using NUnit.Framework;
using WellcomeToLinq;

namespace NUnitTests
{
    [TestFixture]
    public class TestWordsHandlers
    {
        [Test]
        [TestCase(new string[] { "A", "A", "A", "A", "A", "A", "A" }, "A", 7)]
        public void Test_GetFrequentDictionary(string[] frequentWords, string expectedWord, int expectedFrequent)
        {
            string filesPath = @"/Users/Aleks/Projects/DevGame/WellcomeToLinq/Chesterton";
            WordsHandlers wh = new WordsHandlers(filesPath);
            Dictionary<string, int> wordsFreqDict = wh.Test_GetFrequentDictionary(frequentWords);

            foreach (var item in wordsFreqDict)
            {
                string actualWord = item.Key;
                int actualFrequent = item.Value;

                Assert.AreEqual(expectedWord, actualWord);
                Assert.AreEqual(expectedFrequent, actualFrequent);
            }
        }
    }
}


