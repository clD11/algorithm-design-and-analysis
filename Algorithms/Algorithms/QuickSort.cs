namespace Algorithms
{
    public class QuickSort
    {
        public void Sort(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = partitionKR(arr, p, r);
                Sort(arr, p, q - 1);
                Sort(arr, q + 1, r);
            }
        }

        private int partitionKR(int[] arr, int p, int r)
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

        public void partitionCoursera(int[] arr, int l, int r)
        {
            int p = arr[l];
            int i = l + 1;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[0])
                {
                    swap(arr, i, j);
                    i = i + 1;
                }
            }

            swap(arr, l, i - 1);
        }

        private void swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp; 
        }
    }
}
