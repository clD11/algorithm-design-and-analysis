using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
    [TestClass]
    public class QuickSortTest
    {
        private QuickSort testee = new QuickSort();

        [TestInitialize]
        public void TestInitialize()
        {
            testee = new QuickSort();
        }

        [DataTestMethod]
        [DataRow(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(new int[] { 12, 4, 6, 2, 1 }, new int[] { 1, 2, 4, 6, 12 })]
        [DataRow(new int[] { 2, 2, 1, 1, 3 }, new int[] { 1, 1, 2, 2, 3 })]
        public void TestQuickSortShouldReturnSortedArray(int[] actual, int[] expected)
        {
            testee.Sort(actual, 0, actual.Length - 1);
            CollectionAssert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(new int[] { 3, 5, 2, 1, 4 }, new int[] { 1, 2, 3, 5, 4  })]
        public void partitionCoursera(int[] unsorted, int[] expected)
        {
            testee.partitionCoursera(unsorted, 0, unsorted.Length);
            CollectionAssert.AreEqual(expected, unsorted);
        }
    }
}