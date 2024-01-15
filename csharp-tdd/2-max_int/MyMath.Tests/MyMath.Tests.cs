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
        public void Max_MaxMiddle_ReturnsMaxInt()
        {
            List<int> nums = new List<int> { 2, 4, 8, 3, 1};
            int max = Operations.Max(nums);
            Assert.AreEqual(8, max);        
        }

        [Test]
        public void Max_MaxEnd_ReturnsMaxInt()
        {
            List<int> nums = new List<int> { 2, 4, 1, 3, 8};
            int max = Operations.Max(nums);
            Assert.AreEqual(8, max);        
        }

         [Test]
        public void Max_MaxStart_ReturnsMaxInt()
        {
            List<int> nums = new List<int> { 8, 4, 2, 3, 1};
            int max = Operations.Max(nums);
            Assert.AreEqual(8, max);        
        }

        [Test]
        public void Max_ContainsNegitive_ReturnsMaxInt()
        {
            List<int> nums = new List<int> { 2, -4, 8, 3, 1};
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