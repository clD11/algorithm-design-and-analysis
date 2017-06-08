using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Linq;

namespace Algorithms.Tests
{
    [TestClass]
    public class QuickSortTest
    {
        private IQuickSort testee;

        [TestInitialize]
        public void TestInitialize()
        {
            testee = new QuickSort();
        }

        [TestMethod]
        public void TestSortFirstPivot()
        {
            var unsorted = testData();
            var expected = expectedData(unsorted.Length);

            testee.SortFirst(unsorted, 0, unsorted.Length - 1);

            CollectionAssert.AreEqual(expected, unsorted);
        }

        [DataTestMethod]
        [DataRow(new int[] { 11, 5, 2, 14, 20, 7, 6, 8, 13, 1, 12, 16, 15, 10, 18, 3, 19, 17, 4, 9 }, 60)]
        public void TestComparisonsFirstPivot(int[] unsorted, int expected)
        {
            testee.SortFirst(unsorted, 0, unsorted.Length - 1);
            Assert.AreEqual(expected, testee.Comparisons);
        }

        [TestMethod]
        public void TestSortLastPivot()
        {
            var unsorted = testData();
            var expected = expectedData(unsorted.Length);

            testee.SortLast(unsorted, 0, unsorted.Length - 1);

            CollectionAssert.AreEqual(expected, unsorted);
        }

        [DataTestMethod]
        [DataRow(new int[] { 11, 5, 2, 14, 20, 7, 6, 8, 13, 1, 12, 16, 15, 10, 18, 3, 19, 17, 4, 9 }, 68)]
        public void TestComparisonsLastPivot(int[] unsorted, int expected)
        {
            testee.SortLast(unsorted, 0, unsorted.Length - 1);
            Assert.AreEqual(expected, testee.Comparisons);
        }

        [TestMethod]
        public void TestSortMedianPivot()
        {
            var unsorted = testData();
            var expected = expectedData(unsorted.Length);

            testee.SortMedian(unsorted, 0, unsorted.Length - 1);

            CollectionAssert.AreEqual(expected, unsorted);
        }

        [DataTestMethod]
        [DataRow(new int[] { 11, 5, 2, 14, 20, 7, 6, 8, 13, 1, 12, 16, 15, 10, 18, 3, 19, 17, 4, 9 }, 56)]
        public void TestComparisonsMedianPivot(int[] unsorted, int expected)
        {
            testee.SortMedian(unsorted, 0, unsorted.Length - 1);
            Assert.AreEqual(expected, testee.Comparisons);
        }

        private int[] expectedData(int inclusiveRange)
        {
            var sorted = new int[inclusiveRange];

            for (var i = 0; i < inclusiveRange; i++)
            {
                sorted[i] = i + 1;
            }

            return sorted;
        }

        private int[] testData()
        {
            string[] testData = File.ReadLines(@"./TestData/QuickSortData.txt").ToArray();

            Assert.IsTrue(testData.Length == 10000);

            int[] unsorted = new int[testData.Length];

            for (var i = 0; i < unsorted.Length; i++)
            {
                unsorted[i] = int.Parse(testData[i]);
            }

            return unsorted;
        }
    }
}