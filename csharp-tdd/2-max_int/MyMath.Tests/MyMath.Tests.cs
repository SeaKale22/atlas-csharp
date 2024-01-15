using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Max_NormalUse_ReturnsMaxInt()
        {
            List<int> nums = new List<int> { 2, 4, 8, 3, 1};
            int max = Operations.Max(nums);
            Assert.AreEqual(8, max);        
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            int max = Operations.Max(nums);
            Assert.AreEqual(0, max);
        }
    }
}