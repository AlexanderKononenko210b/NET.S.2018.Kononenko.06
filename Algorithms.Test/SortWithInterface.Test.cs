using System;
using NUnit.Framework;
using Algorithms;

namespace Algorithms.Test
{
    /// <summary>
    /// Class for test sort jagged massive method bubble sort across intarface 
    /// as input argument and subcall method with input argument as delegate
    /// </summary>
    [TestFixture]
    public class SortWithInterface
    {
        #region Test BubbleSortInterface with valid data

        /// <summary>
        /// Method for test method SortSummElementAscendArray with valid data
        /// </summary>
        [Test]
        public void BubbleSortInterface_SortSummElementAscendArray_With_Valid_Data()
        {
            var inputArray = HelperSort.GetJaggedArray();

            var comparer =  new SortSummElementAscendArray();

            BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer);

            var outputSummRowArray = HelperSort.SortSummAscendHelper(inputArray).Item2;

            Assert.IsTrue(HelperSort.SortSummAscendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortSummElementDescendArray with valid data
        /// </summary>
        /// 
        [Test]
        public void BubbleSortInterface_SortSummElementDescendArray_With_Valid_Data()
        {
            var inputArray = HelperSort.GetJaggedArray();

            var comparer = new SortSummElementDescendArray();

            BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer);

            var outputSummRowArray = HelperSort.SortSummDescendHelper(inputArray).Item2;

            Assert.IsTrue(HelperSort.SortSummDescendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortMaxElementAscendHelper with valid data
        /// </summary>
        [Test]
        public void BubbleSortInterface_SortMaxElementAscendArray_With_Valid_Data()
        {
            var inputArray = HelperSort.GetJaggedArray();

            var comparer = new SortMaxElementAscendArray();

            BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer);

            var outputMaxElementRowArray = HelperSort.SortMaxElementAscendHelper(inputArray).Item2;

            Assert.IsTrue(HelperSort.SortMaxElementAscendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortMaxElementDescendArray with valid data
        /// </summary>
        [Test]
        public void BubbleSortInterface_SortMaxElementDescendArray_With_Valid_Data()
        {
            var inputArray = HelperSort.GetJaggedArray();

            var comparer = new SortMaxElementDescendArray();

            BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer);

            var outputMaxElementRowArray = HelperSort.SortMaxElementDescendHelper(inputArray).Item2;

            Assert.IsTrue(HelperSort.SortMaxElementDescendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortMinElementAscendArray with valid data
        /// </summary>
        [Test]
        public void BubbleSortInterface_SortMinElementAscendArray_With_Valid_Data()
        {
            var inputArray = HelperSort.GetJaggedArray();

            var comparer = new SortMinElementAscendArray();

            BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer);

            var outputMinElementRowArray = HelperSort.SortMinElementAscendHelper(inputArray).Item2;

            Assert.IsTrue(HelperSort.SortMinElementAscendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortMinElementDescendArray with valid data
        /// </summary>
        [Test]
        public void BubbleSortInterface_SortMinElementDescendArray_With_Valid_Data()
        {
            var inputArray = HelperSort.GetJaggedArray();

            var comparer = new SortMinElementDescendArray();

            BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer);

            var outputMinElementRowArray = HelperSort.SortMinElementDescendHelper(inputArray).Item2;

            Assert.IsTrue(HelperSort.SortMinElementDescendHelper(inputArray).Item1);
        }

        #endregion Test BubbleSortInterface with valid data

        #region Test BubbleSortInterface with not valid data

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortSummElementAscendArray if the referenced array reference refers to null.
        /// </summary>
        [Test]
        public void BubbleSortInterface_SortSummElementAscendArray_Axpected_ArgumentNullException()
        {
            int[][] inputArray = null;

            var comparer = new SortSummElementAscendArray();

            Assert.Throws<ArgumentNullException>(() => BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer));
        }

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortSummElementDescendArray if the referenced array reference refers to null.
        /// </summary>
        [Test]
        public void BubbleSortInterface_SortSummElementDescendArray_Axpected_ArgumentNullException()
        {
            int[][] inputArray = null;

            var comparer = new SortSummElementDescendArray();

            Assert.Throws<ArgumentNullException>(() => BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer));
        }

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortMaxElementAscendArray if the referenced array reference refers to null.
        /// </summary>
        [Test]
        public void BubbleSortInterface_SortMaxElementAscendArray_Axpected_ArgumentNullException()
        {
            int[][] inputArray = null;

            var comparer = new SortMaxElementAscendArray();

            Assert.Throws<ArgumentNullException>(() => BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer));
        }

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortMaxElementDescendArray if the referenced array reference refers to null.
        /// </summary>
        [Test]
        public void BubbleSortInterface_SortMaxElementDescendArray_Axpected_ArgumentNullException()
        {
            int[][] inputArray = null;

            var comparer = new SortMaxElementDescendArray();

            Assert.Throws<ArgumentNullException>(() => BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer));
        }

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortMinElementAscendArray if the referenced array reference refers to null.
        /// </summary>
        [Test]
        public void BubbleSortInterface_SortMinElementAscendArray_Axpected_ArgumentNullException()
        {
            int[][] inputArray = null;

            var comparer = new SortMinElementAscendArray();

            Assert.Throws<ArgumentNullException>(() => BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer));
        }

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortMinElementDescendArray if the referenced array reference refers to null.
        /// </summary>
        [Test]
        public void BubbleSortInterface_SortMinElementDescendArray_Axpected_ArgumentNullException()
        {
            int[][] inputArray = null;

            var comparer = new SortMinElementDescendArray();

            Assert.Throws<ArgumentNullException>(() => BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer));
        }

        /// <summary>
        /// Test SortSummElementAscendArray if expected OverflowException
        /// </summary>
        [Test]
        public void BubbleSortInterface_SortSummElementAscendArray_Apected_OverflowException()
        {
            Random random = new Random();
            int lengthRow = 100;

            int[][] inputArray = new int[lengthRow][];

            for (int i = 0; i < lengthRow; ++i)
            {
                var lengthColumn = random.Next(100000, 1000000);

                inputArray[i] = new int[lengthColumn];

                if (lengthColumn != 0)
                {
                    for (int j = 0; j < lengthColumn; ++j)
                    {
                        inputArray[i][j] = random.Next(-100, 100000);
                    }
                }
            }

            var comparer = new SortSummElementAscendArray();

            Assert.Throws<OverflowException>(() => BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer));
        }

        /// <summary>
        /// Test SortSummElementAscendArray if expected OverflowException
        /// </summary>
        [Test]
        public void BubbleSortInterface_SortSummElementDescendArray_Apected_OverflowException()
        {
            Random random = new Random();
            int lengthRow = 100;

            int[][] inputArray = new int[lengthRow][];

            for (int i = 0; i < lengthRow; ++i)
            {
                var lengthColumn = random.Next(100000, 1000000);

                inputArray[i] = new int[lengthColumn];

                if (lengthColumn != 0)
                {
                    for (int j = 0; j < lengthColumn; ++j)
                    {
                        inputArray[i][j] = random.Next(-100, 100000);
                    }
                }
            }
            var comparer = new SortSummElementDescendArray();

            Assert.Throws<OverflowException>(() => BubbleSortAcrossInterface.BubbleSortInterface(inputArray, comparer));
        }

        #endregion Test BubbleSortInterface with not valid data
    }
}
