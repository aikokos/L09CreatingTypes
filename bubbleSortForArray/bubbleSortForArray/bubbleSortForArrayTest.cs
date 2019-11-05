// <copyright file="BubbleSortForArrayTest.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>

namespace BubbleSortForArray
{
    using NUnit.Framework;

    /// <summary>
    /// Class for testing  BubbleSortForArray class.
    /// </summary>
    public class BubbleSortForArrayTest
    {
        /// <summary>
        /// Method for testing SortByRowSum method.
        /// </summary>
        [Test]
        public void SortByRowSumTest()
        {
            BubbleSortForArray bs = new BubbleSortForArray();
            int[][] jaggedArray1 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 },
                new int[] { 11, 25 }
            };
            int[][] jaggedArray1AfterTest = new int[][]
            {
                new int[] { 11, 25 },
                new int[] { 11, 22 },
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
            };
            Assert.AreEqual(bs.SortByRowSum(jaggedArray1), jaggedArray1AfterTest);
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 55, 5, 5 },
                new int[] { 101, 102 },
                new int[] { 1, 2 },
                new int[] { 6, 7 }
            };
            int[][] jaggedArray2AfterTest = new int[][]
            {
                new int[] { 101, 102 }, new int[] { 55, 5, 5 }, new int[] { 6, 7 }, new int[] { 1, 2 }
            };
            Assert.AreEqual(bs.SortByRowSum(jaggedArray2), jaggedArray2AfterTest);
        }

        /// <summary>
        /// Method for testing SortByRowMax method.
        /// </summary>
        [Test]
        public void SortByRowMaxTest()
        {
            BubbleSortForArray bs = new BubbleSortForArray();
            int[][] jaggedArray1 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 },
                new int[] { 11, 25 }
            };
            int[][] jaggedArray1AfterTest = new int[][]
            {
                new int[] { 11, 25 },
                new int[] { 11, 22 },
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
            };
            Assert.AreEqual(bs.SortByRowMax(jaggedArray1), jaggedArray1AfterTest);
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 55, 5, 5 },
                new int[] { 101, 102 },
                new int[] { 1, 2 },
                new int[] { 6, 7 }
            };
            int[][] jaggedArray2AfterTest = new int[][]
            {
                new int[] { 101, 102 },
                new int[] { 55, 5, 5 },
                new int[] { 6, 7 },
                new int[] { 1, 2 }
            };
            Assert.AreEqual(bs.SortByRowSum(jaggedArray2), jaggedArray2AfterTest);
        }

        /// <summary>
        /// Method for testing SortByRowMin method.
        /// </summary>
        [Test]
        public void SortByRowMinTest()
        {
            BubbleSortForArray bs = new BubbleSortForArray();
            int[][] jaggedArray1 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 10, 11, 22 },
                new int[] { 11, 25 }
            };
            int[][] jaggedArray1AfterTest = new int[][]
            {
                new int[] { 0, 2, 4, 6 },
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 10, 11, 22 },
                new int[] { 11, 25 },
            };
            int[][] testArray = bs.SortByRowMin(jaggedArray1);
            Assert.AreEqual(testArray, jaggedArray1AfterTest);
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 55, 5, 5 },
                new int[] { 101, 102 },
                new int[] { 1, 2 },
                new int[] { 6, 7 }
            };
            int[][] jaggedArray2AfterTest = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 55, 5, 5 },
                new int[] { 6, 7 },
                new int[] { 101, 102 }
            };
            int[][] testArray2 = bs.SortByRowMin(jaggedArray2);
            Assert.AreEqual(testArray2, jaggedArray2AfterTest);
        }
    }
}