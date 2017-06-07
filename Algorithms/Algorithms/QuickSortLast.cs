namespace Algorithms
{
    public class QuickSortLast : IQuickSort
    {
        public long Comparisons { get; set; } = 0;

        public void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                Comparisons += r - l - 1;
                int p = partition(arr, l, r);
                Sort(arr, l, p - 1);
                Sort(arr, p + 1, r);
            }
        }

        private int partition(int[] arr, int p, int r)
        {
            int x = arr[r];
            int i = p - 1;

            for (var j = p; j <= r - 1; j++)
            {
                if (arr[j] <= x)
                {
                    i = i + 1;
                    swap(arr, i, j);
                }
            }

            swap(arr, i + 1, r);

            return i + 1;
        }

        private void swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
