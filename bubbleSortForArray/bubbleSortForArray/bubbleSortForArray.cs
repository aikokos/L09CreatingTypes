// <copyright file="BubbleSortForArray.cs" company="LearningCompany">
// Copyright (c) Company. All rights reserved.
// </copyright>

namespace BubbleSortForArray
{
    /// <summary>
    /// Class performs bubble sort for array by different peculiarities.
    /// </summary>
    public class BubbleSortForArray
    {
        /// <summary>
        /// Method for getting sum of elements.
        /// </summary>
        /// <param name="array">array for getting sum</param>
        /// <returns>Returns the sum of elements.</returns>
        public int SumOfElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        /// <summary>
        /// Method for getting maximum of elements.
        /// </summary>
        /// <param name="array">array for getting maximum</param>
        /// <returns>Returns the maximum of elements.</returns>
        public int GetRowMaxElement(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Method for getting minimum of elements.
        /// </summary>
        /// <param name="array">array for getting minimum</param>
        /// <returns>Returns the minimum of elements.</returns>
        public int GetRowMinElement(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            return min;
        }

        /// <summary>
        /// Method for swapping elements of jagged array.
        /// </summary>
        /// <param name="array">jagged array for swapping</param>
        /// <param name="i1">first row to swap</param>
        /// <param name="i2">second row to swap</param>
        /// <returns>Returns the jagged array with swapped elements.</returns>
        public int[][] Swap(int[][] array, int i1, int i2)
        {
            var temp = array[i2];
            array[i2] = array[i1];
            array[i1] = temp;
            return array;
        }

        /// <summary>
        /// Method for sorting jagged array by sum of elements in row.
        /// </summary>
        /// <param name="array">jagged array for sorting</param>
        /// <returns>Returns the sorted by sum of elements in row array.</returns>
        public int[][] SortByRowSum(int[][] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (this.SumOfElements(array[i]) > this.SumOfElements(array[i - 1]))
                    {
                        this.Swap(array, i, i - 1);
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Method for sorting jagged array by maximum of elements in row.
        /// </summary>
        /// <param name="array">jagged array for sorting</param>
        /// <returns>Returns the sorted by maximum of elements in row array.</returns>
        public int[][] SortByRowMax(int[][] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (this.GetRowMaxElement(array[i]) > this.GetRowMaxElement(array[i - 1]))
                    {
                        this.Swap(array, i, i - 1);
                    }
                }
            }

            return array;
        }

        /// <summary>
        /// Method for sorting jagged array by minimum of elements in row.
        /// </summary>
        /// <param name="array">jagged array for sorting</param>
        /// <returns>Returns the sorted by minimum of elements in row array.</returns>
        public int[][] SortByRowMin(int[][] array)
        {
            for (int j = 1; j < array.Length; j++)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (this.GetRowMinElement(array[i]) < this.GetRowMinElement(array[i - 1]))
                    {
                        this.Swap(array, i, i - 1);
                    }
                }
            }

            return array;
        }
    }
}
