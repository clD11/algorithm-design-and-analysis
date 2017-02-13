using System;

namespace Algorithms
{
    public class MergeSort
    {
        public int[] Sort(int[] array)
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

            left = Sort(left);
            right = Sort(right);

            return Merge(left, right);
        }

        public int[] Merge(int[] left, int[] right)
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
                        merged[k] = right[j++];
                    }
                }

                // Check end cases

                if (j >= right.Length)
                {
                    ++k;

                    for (var e = i; e < left.Length; e++)
                    {
                        merged[k++] = left[e];
                    }

                    return merged;
                }

                if (i >= left.Length)
                {
                    ++k;

                    for (var e = j; e < right.Length; e++)
                    {
                        merged[k++] = right[e];
                    }

                    return merged;
                }
            }

            return merged;
        }
    }
}
