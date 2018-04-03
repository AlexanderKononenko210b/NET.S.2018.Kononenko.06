using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test
{
    /// <summary>
    /// Class helper check result sort
    /// </summary>
    public class HelperSort
    {
        #region Helper

        /// <summary>
        /// Method for check work method SortSummElementAscendArray
        /// </summary>
        /// <param name="inputArray">input array</param>
        /// <returns>Value Tuple result</returns>
        public static (bool, int[]) SortSummAscendHelper(int[][] inputArray)
        {
            int summ1 = 0, summ2 = 0;

            var outputArray = new int[inputArray.GetLength(0)];

            for (int i = 0; i < inputArray.GetLength(0); ++i)
            {
                if (inputArray[i] != null && inputArray[i].Length != 0)
                {
                    summ2 = inputArray[i].Sum();

                    outputArray[i] = summ2;

                    if (summ1 != 0 && summ2 < summ1)
                    {
                        return (false, outputArray);
                    }

                    summ1 = summ2;

                    summ2 = 0;
                }
            }

            return (true, outputArray);
        }

        /// <summary>
        /// Method for check work method SortSummElementDescendArray
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static (bool, int[]) SortSummDescendHelper(int[][] inputArray)
        {
            int summ1 = 0, summ2 = 0;

            var outputArray = new int[inputArray.GetLength(0)];

            for (int i = 0; i < inputArray.GetLength(0); ++i)
            {
                if (inputArray[i] != null && inputArray[i].Length != 0)
                {
                    summ2 = inputArray[i].Sum();

                    outputArray[i] = summ2;

                    if (summ1 != 0 && summ2 > summ1)
                    {
                        return (false, outputArray);
                    }

                    summ1 = summ2;

                    summ2 = 0;
                }
            }

            return (true, outputArray);
        }

        /// <summary>
        /// Method for check work method SortMaxElementAscendArray
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static (bool, int[]) SortMaxElementAscendHelper(int[][] inputArray)
        {
            int maxElement1 = 0, maxElement2 = 0;

            var outputArray = new int[inputArray.GetLength(0)];

            for (int i = 0; i < inputArray.GetLength(0); ++i)
            {
                if (inputArray[i] != null && inputArray[i].Length != 0)
                {
                    maxElement2 = inputArray[i].Max();

                    outputArray[i] = maxElement2;

                    if (maxElement1 != 0 && maxElement2 < maxElement1)
                    {
                        return (false, outputArray);
                    }

                    maxElement1 = maxElement2;

                    maxElement2 = 0;
                }
            }

            return (true, outputArray);
        }

        /// <summary>
        /// Method for check work method SortMaxElementDescendArray
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static (bool, int[]) SortMaxElementDescendHelper(int[][] inputArray)
        {
            int maxElement1 = 0, maxElement2 = 0;

            var outputArray = new int[inputArray.GetLength(0)];

            for (int i = 0; i < inputArray.GetLength(0); ++i)
            {
                if (inputArray[i] != null && inputArray[i].Length != 0)
                {
                    maxElement2 = inputArray[i].Max();

                    outputArray[i] = maxElement2;

                    if (maxElement1 != 0 && maxElement2 > maxElement1)
                    {
                        return (false, outputArray);
                    }

                    maxElement1 = maxElement2;

                    maxElement2 = 0;
                }
            }

            return (true, outputArray);
        }

        /// <summary>
        /// Method for check work method SortMinElementAscendArray
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static (bool, int[]) SortMinElementAscendHelper(int[][] inputArray)
        {
            int minElement1 = 0, minElement2 = 0;

            var outputArray = new int[inputArray.GetLength(0)];

            for (int i = 0; i < inputArray.GetLength(0); ++i)
            {
                if (inputArray[i] != null && inputArray[i].Length != 0)
                {
                    minElement2 = inputArray[i].Min();

                    outputArray[i] = minElement2;

                    if (minElement1 != 0 && minElement2 < minElement1)
                    {
                        return (false, outputArray);
                    }

                    minElement1 = minElement2;

                    minElement2 = 0;
                }
            }

            return (true, outputArray);
        }

        /// <summary>
        /// Method for check work method SortMinElementDescendArray
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static (bool, int[]) SortMinElementDescendHelper(int[][] inputArray)
        {
            int minElement1 = 0, minElement2 = 0;

            var outputArray = new int[inputArray.GetLength(0)];

            for (int i = 0; i < inputArray.GetLength(0); ++i)
            {
                if (inputArray[i] != null && inputArray[i].Length != 0)
                {
                    minElement2 = inputArray[i].Min();

                    outputArray[i] = minElement2;

                    if (minElement1 != 0 && minElement2 > minElement1)
                    {
                        return (false, outputArray);
                    }

                    minElement1 = minElement2;

                    minElement2 = 0;
                }
            }

            return (true, outputArray);
        }

        /// <summary>
        /// Method for get jagged array
        /// </summary>
        /// <returns></returns>
        public static int[][] GetJaggedArray()
        {
            Random random = new Random();
            int lengthRow = 10000;

            int[][] inputArray = new int[lengthRow][];

            for (int i = 0; i < lengthRow; ++i)
            {
                var lengthColumn = random.Next(-5, 50);

                if (lengthColumn > 0)
                {
                    inputArray[i] = new int[lengthColumn];

                    for (int j = 0; j < lengthColumn; ++j)
                    {
                        inputArray[i][j] = random.Next(-100, 100);
                    }
                }
                else
                {
                    if (lengthColumn == 0)
                    {
                        inputArray[i] = null;
                    }
                    else
                    {
                        inputArray[i] = new int[0];
                    }
                }
            }

            return inputArray;
        }

        #endregion Helper
    }
}
