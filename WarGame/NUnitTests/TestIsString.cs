using System;
using NUnit.Framework;

namespace NUnitTests
{
	[TestFixture]
	public class TestIsString
	{
		[TestCase ("str1ng", false)]
        [TestCase ("string", true)]

        public void IsSrting_Test(string input, bool expected)
		{
			bool actual = WarGame.Handlers.IsString(input);
			Assert.AreEqual(expected, actual);
		}
	}
}

