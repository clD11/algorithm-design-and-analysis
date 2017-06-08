namespace Algorithms
{
    public interface IQuickSort
    {
        long Comparisons { get; set; }

        void SortFirst(int[] arr, int l, int r);
        void SortLast(int[] unsorted, int l, int r);
        void SortMedian(int[] unsorted, int l, int r);
    }
}
