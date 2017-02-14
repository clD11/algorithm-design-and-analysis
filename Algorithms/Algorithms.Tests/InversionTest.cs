using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
    [TestClass]
    public class InversionTest
    {
        private Inversion inversion;

        [TestInitialize]
        public void Setup()
        {
            inversion = new Inversion();
        }

        [TestMethod]
        [DataRow(new int[] { }, 0)]
        [DataRow(new int[] { 1 }, 0)]
        [DataRow(new int[] { 1, 2, 3 }, 0)]
        [DataRow(new int[] { 1, 3, 5, 2, 4, 6 }, 3)]
        [DataRow(new int[] { 6, 5, 4, 3, 2, 1}, 15)]        
        public void ShouldCountNumberOfInversions(int[] inversions, long expected)
        {
            var actual = inversion.Count(inversions);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldCountNumberOfInversionsLargeInput()
        {
            string[] testData = File.ReadLines(@"./TestData/InversionData.txt").ToArray();

            var inversions = new int[testData.Length];

            for (var i = 0; i < inversions.Length; i++)
            {
                inversions[i] = int.Parse(testData[i]);
            }

            long expected = 2407905288;
            long actual = inversion.Count(inversions);

            Assert.AreEqual(expected, actual);
        }
    }
}
