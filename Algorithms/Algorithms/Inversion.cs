using System;

namespace Algorithms
{
    public class Inversion
    {
        private long count = 0;

        public long Count(int[] array)
        {
            if (array.Length < 1)
            {
                return count;
            }

            divide(array);

            return count;
        }

        private int[] divide(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            var middle = array.Length / 2;

            var left = new int[middle];
            var right = new int[array.Length - middle];

            Array.Copy(array, left, middle);
            Array.Copy(array, middle, right, 0, right.Length);

            left = divide(left);
            right = divide(right);

            return merge(left, right);
        }

        private int[] merge(int[] left, int[] right)
        {
            var merged = new int[left.Length + right.Length];

            var i = 0;
            var j = 0;

            for (var k = 0; k < merged.Length; k++)
            {
                if (left[i] < right[j])
                {
                    merged[k] = left[i++];
                }
                else
                {
                    if (right[j] < left[i])
                    {
                        count = count + left.Length - i;
                        merged[k] = right[j++];
                    }
                }

                if (j >= right.Length)
                {                   
                    return copy(left, i, merged, ++k);
                }

                if (i >= left.Length)
                {
                    return copy(right, j, merged, ++k);
                }
            }

            return merged;
        }

        private int[] copy(int[] source, int sourceIndex, int[] destination, int destinationIndex)
        {           
            for (var e = sourceIndex; e < source.Length; e++)
            {
                destination[destinationIndex++] = source[e];
            }

            return destination;
        }
    }
}
