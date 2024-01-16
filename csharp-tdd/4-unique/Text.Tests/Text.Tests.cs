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
        public void UniqueChar_NormalUse_ReturnsIndex()
        {
            string str = "thisisastring";
            int index = Str.UniqueChar(str);
            Assert.AreEqual(1, index);
        }

        [Test]
        public void UniqueChar_NoRepeatingChars_ReturnsIndex()
        {
            string str = "abcdefghij";
            int index = Str.UniqueChar(str);
            Assert.AreEqual(0, index);
        }

        [Test]
        public void UniqueChar_OnlyRepeats_RetunsNegOne()
        {
            string str = "aabbccddee";
            int index = Str.UniqueChar(str);
            Assert.AreEqual(-1, index);
        }
    }
}