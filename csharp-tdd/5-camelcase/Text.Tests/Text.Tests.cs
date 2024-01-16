using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CamelCase_OneWord_ReturnsOne()
        {
            int count = Str.CamelCase("word");
            Assert.AreEqual(1, count);
        }

        [Test]
        public void CamelCase_TwoWords_ReturnsCount()
        {
            int count = Str.CamelCase("thisString");
            Assert.AreEqual(2, count);
        }


        [Test]
        public void CamelCase_MultiWord_ReturnsCount()
        {
            int count = Str.CamelCase("thisIsAString");
            Assert.AreEqual(4, count);
        }

        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            int count = Str.CamelCase("");
            Assert.AreEqual(0, count);
        }
    }
}