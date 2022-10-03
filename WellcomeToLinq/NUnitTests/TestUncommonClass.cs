using NUnit.Framework;
using WellcomeToLinq;

namespace NUnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        [TestCase(@"/Users/Aleks/Projects/DevGame/WellcomeToLinq/test", new string[] { "Project", "EBook" })]
        public void Test_GetWordsFromFiles(string filePath, string[] expected)
        {
            string[] actual = Uncommon.GetWordsFromFiles(filePath);
            Assert.AreEqual(expected, actual);
        }
    }
}
