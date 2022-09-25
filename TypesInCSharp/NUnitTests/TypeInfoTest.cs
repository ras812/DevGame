using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]

    public class TypeInfoTest
    {
        [Test]
        [TestCase(typeof(int), "System.Int32")]
        [TestCase(typeof(bool), "System.Boolean")]
        [TestCase(typeof(string), "System.String")]
        public void GetTypeNameTest(Type typeOfElement, string expected)
        {
            TypesInCSharp.TypeInfo t = new TypesInCSharp.TypeInfo(typeOfElement);
            string actual = t.TypeName;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(typeof(int), true)]
        [TestCase(typeof(bool), true)]
        [TestCase(typeof(string), false)]
        public void GetIsValueType(Type typeOfElement, bool expected)
        {
            TypesInCSharp.TypeInfo t = new TypesInCSharp.TypeInfo(typeOfElement);
            bool actual = t.IsValueType;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(typeof(int), "System")]
        [TestCase(typeof(bool), "System")]
        [TestCase(typeof(string), "System")]
        public void GetNamespace(Type typeOfElement, string expected)
        {
            TypesInCSharp.TypeInfo t = new TypesInCSharp.TypeInfo(typeOfElement);
            string actual = t.Namespace;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(typeof(int), "System.Private.CoreLib")]
        [TestCase(typeof(bool), "System.Private.CoreLib")]
        [TestCase(typeof(string), "System.Private.CoreLib")]
        public void GetAssemblyName(Type typeOfElement, string expected)
        {
            TypesInCSharp.TypeInfo t = new TypesInCSharp.TypeInfo(typeOfElement);
            string actual = t.Assembly;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(typeof(int), 23)]
        [TestCase(typeof(bool), 16)]
        [TestCase(typeof(string), 157)]
        public void GetElementsCount(Type typeOfElement, int expected)
        {
            TypesInCSharp.TypeInfo t = new TypesInCSharp.TypeInfo(typeOfElement);
            int actual = t.ElementsCount;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(typeof(int), 2)]
        [TestCase(typeof(bool), 2)]
        [TestCase(typeof(string), 1)]
        public void GetFieldsCount(Type typeOfElement, int expected)
        {
            TypesInCSharp.TypeInfo t = new TypesInCSharp.TypeInfo(typeOfElement);
            int actual = t.FieldsCount;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(typeof(int), 0)]
        [TestCase(typeof(bool), 0)]
        [TestCase(typeof(string), 2)]
        public void GetPropertiesCount(Type typeOfElement, int expected)
        {
            TypesInCSharp.TypeInfo t = new TypesInCSharp.TypeInfo(typeOfElement);
            int actual = t.PropertiesCount;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(typeof(int), 21)]
        [TestCase(typeof(bool), 14)]
        [TestCase(typeof(string), 154)]
        public void GetMethodsCount(Type typeOfElement, int expected)
        {
            TypesInCSharp.TypeInfo t = new TypesInCSharp.TypeInfo(typeOfElement);
            int actual = t.MethodsCount;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(typeof(int), new string[] {"MaxValue", "MinValue"})]
        [TestCase(typeof(bool), new string[]{"TrueString", "FalseString"})]
        [TestCase(typeof(string), new string[]{"Empty"})]
        public void GetFieldsInThisType(Type typeOfElement, string[] expected)
        {
            TypesInCSharp.TypeInfo t = new TypesInCSharp.TypeInfo(typeOfElement);
            string[] actual = t.FieldsInType;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(typeof(int), new string[] {})]
        [TestCase(typeof(bool), new string[]{})]
        [TestCase(typeof(string), new string[]{"Chars", "Length"})]
        public void GetPropertiesInThisType(Type typeOfElement, string[] expected)
        {
            TypesInCSharp.TypeInfo t = new TypesInCSharp.TypeInfo(typeOfElement);
            string[] actual = t.PropertiesInType;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(typeof(int), "Equals", "Equals 2 1 1")]
        [TestCase(typeof(bool), "TryParse", "TryParse 2 2 2")]
        [TestCase(typeof(string), "CopyTo", "CopyTo 1 4 4")]
        public void GetDictMethodsInType(Type typeOfElement, string methodName, string expected)
        {
            TypesInCSharp.TypeInfo t = new TypesInCSharp.TypeInfo(typeOfElement);

            Dictionary<string, int[]> actual =  t.DictMethodsInType;

            Assert.AreEqual(expected, $"{methodName} {string.Join(" ", actual[methodName])}");
        }
    }
}

