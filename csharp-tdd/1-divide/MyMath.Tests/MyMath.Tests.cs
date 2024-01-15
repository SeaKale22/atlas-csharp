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
        public void Divide_NormalDivision_ReturnsNewMatrix()
        {
            int[,] myMatrix = new int[,]
            {
                {2, 4, 6},
                {8, 10, 12}
            };

            int[,] newMatrix;

            newMatrix = Matrix.Divide(myMatrix, 2);

            int[,] testMatrix = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6}
            };

            CollectionAssert.AreEqual(testMatrix, newMatrix);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] newMatrix  = Matrix.Divide(null, 2);
            Assert.IsNull(newMatrix);
        }

        [Test]
        public void Divide_ZeroDivision_RetunsNull()
        {
            int[,] myMatrix = new int[,]
            {
                {2, 4, 6},
                {8, 10, 12}
            };

            int[,] newMatrix  = Matrix.Divide(myMatrix, 0);
            Assert.IsNull(newMatrix);
        }
    }
}