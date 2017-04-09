using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class MergeSortTest
    {
        private MergeSort mergeSort;

        [TestInitialize]
        public void Setup()
        {
            mergeSort = new MergeSort();
        }

        [TestMethod]
        [DataRow(new int[] { 1 }, new int[] { 1 })]
        [DataRow(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 } )]
        public void ShouldReturnSortedArray(int[] unsorted, int[] expected)
        {
            var actual = mergeSort.Sort(unsorted);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 2 }, new int[] { 1 }, new int[] { 1, 2 })]
        [DataRow(new int[] { 2, 3 }, new int[] { 1 }, new int[] { 1, 2, 3 })]
        [DataRow(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]        
        public void ShouldMergeAndSortArray(int[] left, int[] right, int[] expected)
        {
            var actual = mergeSort.Merge(left, right);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
