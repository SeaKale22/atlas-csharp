using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            int a = 3;
            int b = 4;

            int result = Operations.Add(a, b);

            Assert.AreEqual(7, result);
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsSum()
        {
            int a = -3;
            int b = -5;

            int result = Operations.Add(a, b);

            Assert.AreEqual(-8, result);
        }

        [Test]
        public void Add_PositiveAndNegativeNumbers_ReturnsSum()
        {
            int a = 3;
            int b = -2;
            int result = Operations.Add(a, b);
            Assert.AreEqual(1, result);
        }
    }
}