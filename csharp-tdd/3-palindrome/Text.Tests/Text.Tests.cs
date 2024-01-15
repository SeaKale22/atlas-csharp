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
        public void IsPalindrome_SingleWordCaps_RetunsTrue()
        {
            string str = "Racecar";
            Assert.IsTrue(Str.IsPalindrome(str));
        }

        [Test]
        public void IsPalindrome_SingleWord_RetunsTrue()
        {
            string str = "level";
            Assert.IsTrue(Str.IsPalindrome(str));
        }

        [Test]
        public void IsPalindrome_HasPunctuation_ReturnsTrue()
        {
            string str = "A man, a plan, a canal: Panama.";
            Assert.IsTrue(Str.IsPalindrome(str));
        }

        [Test]
        public void IsPalindrome_SingleWord_RetunsFalse()
        {
            string str = "kitten";
            Assert.IsFalse(Str.IsPalindrome(str));
        }

        [Test]
        public void IsPalindrome_HasPunctuation_ReturnsFalse()
        {
            string str = "Welp, I got nothing; same as you";
            Assert.IsFalse(Str.IsPalindrome(str));
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            string str = "";
            Assert.IsTrue(Str.IsPalindrome(str));
        }
    }
}