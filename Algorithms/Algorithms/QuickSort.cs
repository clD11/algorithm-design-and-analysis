namespace Algorithms
{
    public class QuickSort : IQuickSort
    {
        /// <summary>
        /// Recurse each partitioned subarray around pivot,
        /// everything to left is less than everything to right
        /// </summary>
        /// <param name="arr">Array to be sorted</param>
        /// <param name="l">Left array index</param>
        /// <param name="r">Right array index</param>

        public long Comparisons { get; set; } = 0;

        public void SortFirst(int[] arr, int l, int r)
        {
            if (l < r)
            {
                Comparisons += r - l;

                int p = partition(arr, l, r);
                SortFirst(arr, l, p - 1);
                SortFirst(arr, p + 1, r);
            }
        }

        public void SortLast(int[] arr, int l, int r)
        {
            if (l < r)
            {
                Comparisons += r - l;

                swap(arr, l, r);

                int p = partition(arr, l, r);
                SortLast(arr, l, p - 1);
                SortLast(arr, p + 1, r);
            }
        }

        public void SortMedian(int[] arr, int l, int r)
        {
            if (l < r)
            {
                Comparisons += r - l;

                var len = r + l + 1;

                var median = 0;

                if (len % 2 == 0)
                {
                    median = len / 2 - 1;
                }
                else
                {
                    median = len / 2;
                }

                swap(arr, l, median);

                int p = partition(arr, l, r);
                SortMedian(arr, l, p - 1);
                SortMedian(arr, p + 1, r);
            }
        }

        private int partition(int[] arr, int l, int r)
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
