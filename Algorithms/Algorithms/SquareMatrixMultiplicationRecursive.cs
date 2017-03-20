namespace Algorithms
{
    public class SquareMatrixMultiplicationRecursive : IMatrixMultiplication
    {
        public int[,] Multiply(int[,] m1, int[,] m2)
        {
            var rows = m1.GetLength(0);

            int[,] product = new int[rows, rows];

            if (rows == 1)
            {
                product [0, 0] = m1[0, 0] * m2[0, 0]; 
            }
            else
            {
                // partition product, m1, m2 into n/2 x n/2 matricies 
            }

            return product;
        }
    }
}
