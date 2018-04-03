using System;
using System.Collections;
using System.Text;

namespace Algorithms
{
    /// <summary>
    /// Class method bubble sort
    /// </summary>
    public static class MethodsForAlgorithms
    {
        #region SortJaggedArray

        /// <summary>
        /// Interface for compare two array in jagged array
        /// </summary>
        public interface IComparerArray
        {
            int Compare(int[] arrayLeft, int[] arrayRight);
        }

        /// <summary>
        /// Method for bubble sort input array
        /// </summary>
        /// <param name="inputArray">input array</param>
        /// <param name="comparer">object for compare two array</param>
        public static void BubbleSort(int[][] inputArray, IComparerArray comparer)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException($"Argument {nameof(inputArray)} is null");
            }

            if (comparer == null)
            {
                throw new ArgumentNullException($"Argument {nameof(comparer)} is null");
            }

            if (inputArray.GetLength(0) == 0)
            {
                throw new ArgumentOutOfRangeException($"Argument`s {nameof(inputArray)} length is 0");
            }

            int depthSort = inputArray.GetLength(0);

            while (depthSort != 1)
            {
                for (int i = 0; i < depthSort - 1; ++i)
                {
                    if (comparer.Compare(inputArray[i], inputArray[i+1]) > 0)
                    {
                        Swap(ref inputArray[i], ref inputArray[i + 1]);
                    }
                }

                depthSort--;
            }
        }

        /// <summary>
        /// Method for change array in jagged array
        /// </summary>
        /// <param name="left">left array</param>
        /// <param name="right">right array</param>
        public static void Swap(ref int[] left, ref int[] right)
        {
            var helper = left;

            left = right;

            right = helper;
        }

        #endregion SortJaggedArray
    }
}
