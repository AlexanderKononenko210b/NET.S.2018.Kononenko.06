using System;
using System.Text;

namespace Algorithms
{
    public static class MethodsForAlgorithms
    {
        #region SortJaggedMassive

        /// <summary>
        /// Method for sorting rows of an array by increasing the sum of elements in a row
        /// </summary>
        /// <param name="inputArray">input array</param>
        public static void SortSummElementAscendArray(int[][] inputArray)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException($"Argument {nameof(inputArray)} is null");
            }

            if (inputArray.GetLength(0) == 0)
            {
                throw new ArgumentOutOfRangeException($"Argument`s {nameof(inputArray)} length is 0");
            }

            int summ1 = 0, summ2 = 0, depthSort = inputArray.GetLength(0);

            while (depthSort != 1)
            {
                for (int i = 0; i < depthSort; ++i)
                {
                    summ2 = FindSummElement(inputArray[i]);

                    if (summ1 != 0 & summ2 < summ1)
                    {
                        ChangeElementInRow(inputArray, i);
                    }
                    else
                    {
                        summ1 = summ2;
                    }
                }

                depthSort--;
                summ1 = summ2 = 0;
            }
        }

        /// <summary>
        /// Method for sorting rows of an array by descending the sum of elements in a row
        /// </summary>
        /// <param name="inputArray">input array</param>
        public static void SortSummElementDescendArray(int[][] inputArray)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException($"Argument {nameof(inputArray)} is null");
            }

            if (inputArray.GetLength(0) == 0)
            {
                throw new ArgumentOutOfRangeException($"Argument`s {nameof(inputArray)} length is 0");
            }

            int summ1 = 0, summ2 = 0, depthSort = inputArray.GetLength(0);

            while (depthSort != 1)
            {
                for (int i = 0; i < depthSort; ++i)
                {
                    summ2 = FindSummElement(inputArray[i]);

                    if (summ1 != 0 & summ2 > summ1)
                    {
                        ChangeElementInRow(inputArray, i);
                    }
                    else
                    {
                        summ1 = summ2;
                    }
                }

                depthSort--;
                summ1 = summ2 = 0;
            }
        }

        /// <summary>
        /// The method of sorting rows of an array by increasing the max values of the elements
        /// </summary>
        /// <param name="inputArray">input array</param>
        public static void SortMaxElementAscendArray(int[][] inputArray)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException($"Argument {nameof(inputArray)} is null");
            }

            if (inputArray.Length == 0)
            {
                throw new ArgumentOutOfRangeException($"Argument`s {nameof(inputArray)} length is 0");
            }

            int maxElement1 = 0, maxElement2 = 0, depthSort = inputArray.GetLength(0);

            while (depthSort != 1)
            {
                for (int i = 0; i < inputArray.GetLength(0); ++i)
                {
                    maxElement2 = FindMaxElement(inputArray[i]);

                    if (maxElement1 != 0 && maxElement2 < maxElement1)
                    {
                        ChangeElementInRow(inputArray, i);
                    }
                    else
                    {
                        maxElement1 = maxElement2;
                    }
                }

                depthSort--;

                maxElement1 = maxElement2 = 0;
            }
        }

        /// <summary>
        /// The method of sorting rows of an array by decreasing the max values of the elements
        /// </summary>
        /// <param name="inputArray">input array</param>
        public static void SortMaxElementDescendArray(int[][] inputArray)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException($"Argument {nameof(inputArray)} is null");
            }

            if (inputArray.Length == 0)
            {
                throw new ArgumentOutOfRangeException($"Argument`s {nameof(inputArray)} length is 0");
            }

            int maxElement1 = 0, maxElement2 = 0, depthSort = inputArray.GetLength(0);

            while (depthSort != 1)
            {
                for (int i = 0; i < inputArray.GetLength(0); ++i)
                {
                    maxElement2 = FindMaxElement(inputArray[i]);

                    if (maxElement1 != 0 && maxElement2 > maxElement1)
                    {
                        ChangeElementInRow(inputArray, i);
                    }
                    else
                    {
                        maxElement1 = maxElement2;
                    }
                }

                depthSort--;

                maxElement1 = maxElement2 = 0;
            }
        }

        /// <summary>
        /// The method of sorting rows of an array by increasing the max values of the elements
        /// </summary>
        /// <param name="inputArray">input array</param>
        public static void SortMinElementAscendArray(int[][] inputArray)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException($"Argument {nameof(inputArray)} is null");
            }

            if (inputArray.Length == 0)
            {
                throw new ArgumentOutOfRangeException($"Argument`s {nameof(inputArray)} length is 0");
            }

            int minElement1 = 0, minElement2 = 0, depthSort = inputArray.GetLength(0);

            while (depthSort != 1)
            {
                for (int i = 0; i < inputArray.GetLength(0); ++i)
                {
                    minElement2 = FindMinElement(inputArray[i]);

                    if (minElement1 != 0 && minElement2 < minElement1)
                    {
                        ChangeElementInRow(inputArray, i);
                    }
                    else
                    {
                        minElement1 = minElement2;
                    }
                }

                depthSort--;

                minElement1 = minElement2 = 0;
            }
        }

        /// <summary>
        /// The method of sorting rows of an array by decreasing the max values of the elements
        /// </summary>
        /// <param name="inputArray">input array</param>
        public static void SortMinElementDescendArray(int[][] inputArray)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException($"Argument {nameof(inputArray)} is null");
            }

            if (inputArray.Length == 0)
            {
                throw new ArgumentOutOfRangeException($"Argument`s {nameof(inputArray)} length is 0");
            }

            int minElement1 = 0, minElement2 = 0, depthSort = inputArray.GetLength(0);
            while (depthSort != 1)
            {
                for (int i = 0; i < inputArray.GetLength(0); ++i)
                {
                    minElement2 = FindMinElement(inputArray[i]);

                    if (minElement1 != 0 && minElement2 > minElement1)
                    {
                        ChangeElementInRow(inputArray, i);
                    }
                    else
                    {
                        minElement1 = minElement2;
                    }
                }

                depthSort--;

                minElement1 = minElement2 = 0;
            }
        }

        /// <summary>
        /// Method for change of element in the row
        /// </summary>
        /// <param name="inputArray">input array</param>
        /// <param name="indexRowSource">index row source</param>
        /// <param name="indexRowDestination">index row source</param>
        /// <returns>value summ elements</returns>
        public static void ChangeElementInRow(int[][] inputArray, int indexRowSource)
        {
            var helper = inputArray[indexRowSource];

            inputArray[indexRowSource] = inputArray[indexRowSource - 1];

            inputArray[indexRowSource - 1] = helper;
        }

        /// <summary>
        /// Method for summ of element in the row
        /// </summary>
        /// <param name="inputArray">input array</param>
        /// <param name="indexRow">index row for search</param>
        /// <returns>value summ elements</returns>
        public static int FindSummElement(int[] inputArray)
        {
            var summElement = 0;

            for (int j = 0; j < inputArray.Length; ++j)
            {
                checked
                {
                    summElement += inputArray[j];
                }
            }

            return summElement;
        }

        /// <summary>
        /// Method for search max element in the row
        /// </summary>
        /// <param name="inputArray">input array</param>
        /// <param name="indexRow">index row for search</param>
        /// <returns>value max element</returns>
        public static int FindMaxElement(int[] inputArray)
        {
            var maxElement = inputArray[0];

            for (int j = 1; j < inputArray.Length; ++j)
            {
                if (inputArray[j] > maxElement)
                {
                    maxElement = inputArray[j];
                }
            }

            return maxElement;
        }

        /// <summary>
        /// Method for search min element in the row
        /// </summary>
        /// <param name="inputArray">input array</param>
        /// <param name="indexRow">index row for search</param>
        /// <returns>value min element</returns>
        public static int FindMinElement(int[]inputArray)
        {
            var minElement = inputArray[0];

            for (int j = 1; j < inputArray.Length; ++j)
            {
                if (inputArray[j] < minElement)
                {
                    minElement = inputArray[j];
                }
            }

            return minElement;
        }

        #endregion SortJaggedMassive

        #region SortMassiveHelper
        /// <summary>
        /// Method for check work method SortSummElementAscendArray
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static (bool, int[]) SortSummAscendHelper(int[][] inputArray)
        {
            int summ1 = 0, summ2 = 0;

            var outputArray = new int[inputArray.GetLength(0)];

            for (int i = 0; i < inputArray.GetLength(0); ++i)
            {
                summ2 = FindSummElement(inputArray[i]);

                outputArray[i] = summ2;

                if (summ1 != 0 && summ2 < summ1)
                {
                    return (false, outputArray);
                }

                summ1 = summ2;

                summ2 = 0;
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
                summ2 = FindSummElement(inputArray[i]);

                outputArray[i] = summ2;

                if (summ1 != 0 && summ2 > summ1)
                {
                    return (false, outputArray);
                }

                summ1 = summ2;

                summ2 = 0;
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
                maxElement2 = FindMaxElement(inputArray[i]);

                outputArray[i] = maxElement2;

                if (maxElement1 != 0 && maxElement2 < maxElement1)
                {
                    return (false, outputArray);
                }

                maxElement1 = maxElement2;

                maxElement2 = 0;
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
                maxElement2 = FindMaxElement(inputArray[i]);

                outputArray[i] = maxElement2;

                if (maxElement1 != 0 && maxElement2 > maxElement1)
                {
                    return (false, outputArray);
                }

                maxElement1 = maxElement2;

                maxElement2 = 0;
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
                minElement2 = FindMinElement(inputArray[i]);

                outputArray[i] = minElement2;

                if (minElement1 != 0 && minElement2 < minElement1)
                {
                    return (false, outputArray);
                }

                minElement1 = minElement2;

                minElement2 = 0;
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
                minElement2 = FindMinElement(inputArray[i]);

                outputArray[i] = minElement2;

                if (minElement1 != 0 && minElement2 > minElement1)
                {
                    return (false, outputArray);
                }

                minElement1 = minElement2;

                minElement2 = 0;
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
                var lengthColumn = random.Next(1, 50);

                inputArray[i] = new int[lengthColumn];

                if (lengthColumn != 0)
                {
                    for (int j = 0; j < lengthColumn; ++j)
                    {
                        inputArray[i][j] = random.Next(-100, 100);
                    }
                }
            }

            return inputArray;
        }

        #endregion SortMassiveHelper    
    }
}
