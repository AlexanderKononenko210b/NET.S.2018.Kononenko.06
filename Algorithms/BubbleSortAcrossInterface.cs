using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Class method bubble sort across intarface as input argument 
    /// and subcall method with input argument as delegate
    /// </summary>
    public static class BubbleSortAcrossInterface
    {
        #region SortJaggedArray

        public delegate int ComparerDelegate(int[] first, int[] second);

        /// <summary>
        /// Method for bubble sort input array
        /// </summary>
        /// <param name="inputArray">input array</param>
        /// <param name="comparer">object for compare two array</param>
        public static void BubbleSortInterface(int[][] inputArray, IComparerArray comparer)
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

            var methodInfo = comparer.GetType().GetMethod("Compare");

            var delegat = (ComparerDelegate)Delegate.CreateDelegate(typeof(ComparerDelegate), null, methodInfo);

            BubbleSortDelegate(inputArray, delegat);
        }

        /// <summary>
        /// Method for bubble sort input array
        /// </summary>
        /// <param name="inputArray">input array</param>
        /// <param name="comparer">object for compare two array</param>
        public static void BubbleSortDelegate(int[][] inputArray, ComparerDelegate delegateInput)
        {
            int depthSort = inputArray.GetLength(0);

            while (depthSort != 1)
            {
                for (int i = 0; i < depthSort - 1; ++i)
                {
                    if (delegateInput.Invoke(inputArray[i], inputArray[i + 1]) > 0)
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
