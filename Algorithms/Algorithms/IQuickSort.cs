namespace Algorithms
{
    public interface IQuickSort
    {
        void Sort(int[] arr, int l, int r);
        long Comparisons { get; set; }
    }
}
