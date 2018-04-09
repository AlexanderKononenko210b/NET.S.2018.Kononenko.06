using System;
using NUnit.Framework;

namespace Algorithms.Test
{
    /// <summary>
    /// Class for test sort jagged massive method bubble sort across delegate
    /// as input argument and subcall method with input argument as interface
    /// </summary>
	[TestFixture]
	public class SortWithDelegate
	{
        #region Test BubbleSortDelegate with valid data

        /// <summary>
        /// Method for test method SortSummElementAscendArray with valid data
        /// </summary>
        [Test]
        public void BubbleSortDelegate_SortSummElementAscendArray_With_Valid_Data()
        {
            var inputArray = HelperSort.GetJaggedArray();

            var comparer = new SortSummElementAscendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput);

            var outputSummRowArray = HelperSort.SortSummAscendHelper(inputArray).Item2;

            Assert.IsTrue(HelperSort.SortSummAscendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortSummElementDescendArray with valid data
        /// </summary>
        /// 
        [Test]
        public void BubbleSortDelegate_SortSummElementDescendArray_With_Valid_Data()
        {
            var inputArray = HelperSort.GetJaggedArray();

            var comparer = new SortSummElementDescendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput);

            var outputSummRowArray = HelperSort.SortSummDescendHelper(inputArray).Item2;

            Assert.IsTrue(HelperSort.SortSummDescendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortMaxElementAscendHelper with valid data
        /// </summary>
        [Test]
        public void BubbleSortDelegate_SortMaxElementAscendArray_With_Valid_Data()
        {
            var inputArray = HelperSort.GetJaggedArray();

            var comparer = new SortMaxElementAscendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput);

            var outputMaxElementRowArray = HelperSort.SortMaxElementAscendHelper(inputArray).Item2;

            Assert.IsTrue(HelperSort.SortMaxElementAscendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortMaxElementDescendArray with valid data
        /// </summary>
        [Test]
        public void BubbleSortDelegate_SortMaxElementDescendArray_With_Valid_Data()
        {
            var inputArray = HelperSort.GetJaggedArray();

            var comparer = new SortMaxElementDescendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput);

            var outputMaxElementRowArray = HelperSort.SortMaxElementDescendHelper(inputArray).Item2;

            Assert.IsTrue(HelperSort.SortMaxElementDescendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortMinElementAscendArray with valid data
        /// </summary>
        [Test]
        public void BubbleSortDelegate_SortMinElementAscendArray_With_Valid_Data()
        {
            var inputArray = HelperSort.GetJaggedArray();

            var comparer = new SortMinElementAscendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput);

            var outputMinElementRowArray = HelperSort.SortMinElementAscendHelper(inputArray).Item2;

            Assert.IsTrue(HelperSort.SortMinElementAscendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortMinElementDescendArray with valid data
        /// </summary>
        [Test]
        public void BubbleSortDelegate_SortMinElementDescendArray_With_Valid_Data()
        {
            var inputArray = HelperSort.GetJaggedArray();

            var comparer = new SortMinElementDescendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput);

            var outputMinElementRowArray = HelperSort.SortMinElementDescendHelper(inputArray).Item2;

            Assert.IsTrue(HelperSort.SortMinElementDescendHelper(inputArray).Item1);
        }

        #endregion Test BubbleSortDelegate with valid data

        #region Test BubbleSortDelegate with not valid data

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortSummElementAscendArray if the referenced array reference refers to null.
        /// </summary>
        [Test]
        public void BubbleSortDelegate_SortSummElementAscendArray_Axpected_ArgumentNullException()
        {
            int[][] inputArray = null;

            var comparer = new SortSummElementAscendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            Assert.Throws<ArgumentNullException>(() => BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput));
        }

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortSummElementDescendArray if the referenced array reference refers to null.
        /// </summary>
        [Test]
        public void BubbleSortDelegate_SortSummElementDescendArray_Axpected_ArgumentNullException()
        {
            int[][] inputArray = null;

            var comparer = new SortSummElementDescendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            Assert.Throws<ArgumentNullException>(() => BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput));
        }

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortMaxElementAscendArray if the referenced array reference refers to null.
        /// </summary>
        [Test]
        public void BubbleSortDelegate_SortMaxElementAscendArray_Axpected_ArgumentNullException()
        {
            int[][] inputArray = null;

            var comparer = new SortMaxElementAscendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            Assert.Throws<ArgumentNullException>(() => BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput));
        }

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortMaxElementDescendArray if the referenced array reference refers to null.
        /// </summary>
        [Test]
        public void BubbleSortDelegate_SortMaxElementDescendArray_Axpected_ArgumentNullException()
        {
            int[][] inputArray = null;

            var comparer = new SortMaxElementDescendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            Assert.Throws<ArgumentNullException>(() => BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput));
        }

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortMinElementAscendArray if the referenced array reference refers to null.
        /// </summary>
        [Test]
        public void BubbleSortDelegate_SortMinElementAscendArray_Axpected_ArgumentNullException()
        {
            int[][] inputArray = null;

            var comparer = new SortMinElementAscendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            Assert.Throws<ArgumentNullException>(() => BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput));
        }

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortMinElementDescendArray if the referenced array reference refers to null.
        /// </summary>
        [Test]
        public void BubbleSortDelegate_SortMinElementDescendArray_Axpected_ArgumentNullException()
        {
            int[][] inputArray = null;

            var comparer = new SortMinElementDescendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            Assert.Throws<ArgumentNullException>(() => BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput));
        }

        /// <summary>
        /// Test SortSummElementAscendArray if expected OverflowException
        /// </summary>
        [Test]
        public void BubbleSortDelegate_SortSummElementAscendArray_Axpected_OverflowException()
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

            var comparer = new SortSummElementAscendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            Assert.Throws<OverflowException>(() => BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput));
        }

        /// <summary>
        /// Test SortSummElementAscendArray if expected OverflowException
        /// </summary>
        [Test]
        public void BubbleSortDelegate_SortSummElementDescendArray_Axpected_OverflowException()
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
            var comparer = new SortSummElementDescendArrayWithoutInterface();

            Func<int[], int[], int> delegatInput = comparer.Compare;

            Assert.Throws<OverflowException>(() => BubbleSortAcrossDelegate.BubbleSortDelegate(inputArray, delegatInput));
        }

        #endregion Test BubbleSortDelegate with not valid data
    }
}
