using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public interface IMatrixMultiplication
    {
        int[,] Multiply(int[,] m1, int[,] m2);
    }
}
