namespace Algorithms
{
    public class QuickSort
    {
        public void Sort(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = partition(arr, p, r);
                Sort(arr, p, q - 1);
                Sort(arr, q + 1, r);
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
