namespace Algorithms
{
    public class QuickSort
    {
        /// <summary>
        /// Recurse each partitioned subarry around pivot,
        /// everything to left is less than everything to right
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        /// <param name="l">Left array index</param>
        /// <param name="r">Right array index</param>

        public int Comparisons { get; set; } = 0;

        // Uses first element as pivot
        public void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                Comparisons += r - l - 1;
                int p = partitionCoursera(arr, l, r);
                Sort(arr, l, p);
                Sort(arr, p + 1, r);
            }
        }

        public int partitionCoursera(int[] arr, int l, int r)
        {
            int pivot = arr[l];
            int i = l + 1;

            for (int j = l + 1; j <= r; j++)
            {
                if (arr[j] < pivot)
                {
                    swap(arr, i, j);
                    i = i + 1;
                }
            }

            swap(arr, l, i - 1);

            return i - 1;
        }

        private void swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp; 
        }
    }
}
