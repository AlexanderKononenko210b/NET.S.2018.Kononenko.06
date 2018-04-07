using System;
using System.Collections;
using System.Text;

namespace Algorithms
{
    /// <summary>
    /// Class method bubble sort across delegate as input
    /// argument and subcall method with input argument as interface
    /// </summary>
    public static class BubbleSortAcrossDelegate
    {
        #region SortJaggedArray

        public delegate int ComparerDelegate(int[] first, int[] second);

        /// <summary>
        /// Method for bubble sort input array using interface
        /// </summary>
        /// <param name="inputArray">input array</param>
        /// <param name="comparer">object for compare two array</param>
        public static void BubbleSortInterface(int[][] inputArray, IComparerArray comparer)
        {
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
        /// Method for bubble sort input array using delegate
        /// </summary>
        /// <param name="inputArray">input array</param>
        /// <param name="comparer">object for compare two array</param>
        public static void BubbleSortDelegate(int[][] inputArray, ComparerDelegate delegateInput)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException($"Argument {nameof(inputArray)} is null");
            }

            if (delegateInput == null)
            {
                throw new ArgumentNullException($"Argument {nameof(delegateInput)} is null");
            }

            if (inputArray.GetLength(0) == 0)
            {
                throw new ArgumentOutOfRangeException($"Argument`s {nameof(inputArray)} length is 0");
            }

            var obj = (IComparerArray)delegateInput.Target;

            BubbleSortInterface(inputArray, obj);
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
