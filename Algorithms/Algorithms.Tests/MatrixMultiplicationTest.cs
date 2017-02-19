using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class MatrixMultiplicationTest
    {       
        private IMatrixMultiplication matrixMultiplication;

        [TestMethod]
        public void ShouldMultiplyMatriciesCubic()
        {
            matrixMultiplication = new SquareMatrixMultiplication();

            int[,] m1 = { { 1, 2, }, { 3, 4 } };
            int[,] m2 = { { 5, 6 }, { 7, 8 } };

            int[,] expected = { { 19, 22 }, { 43, 50 } };
            var actual = matrixMultiplication.Multiply(m1, m2);            

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldMultiplyMatriciesSubcubic()
        {
            matrixMultiplication = new StrassenMatrixMultiplication();

            int[,] m1 = { { 1, 2, }, { 3, 4 } };
            int[,] m2 = { { 5, 6 }, { 7, 8 } };

            int[,] expected = { { 19, 22 }, { 43, 50 } };
            var actual = matrixMultiplication.Multiply(m1, m2);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
