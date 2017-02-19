namespace Algorithms
{
    public class SquareMatrixMultiplication : IMatrixMultiplication
    {
        public int[,] Multiply(int[,] m1, int[,] m2)
        {
            var rows = m1.GetLength(0);

            int[,] product = new int[rows, rows];

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < rows; j++)
                {
                    product[i, j] = 0;

                    for (var k = 0; k < rows; k++)
                    {
                        product[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }            

            return product;
        }
    }
}
