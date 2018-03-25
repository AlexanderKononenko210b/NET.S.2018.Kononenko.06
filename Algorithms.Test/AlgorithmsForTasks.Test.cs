using System;
using NUnit.Framework;
using Algorithms;

namespace UnitTestAlgorithms
{
    /// <summary>
    /// Class for test sort jagged massive
    /// </summary>
    [TestFixture]
    public class AlgorithmsForTasks
    {
        /// <summary>
        /// Method for test method SortSummElementAscendArray with valid data
        /// </summary>
        [Test]
        public void SortSummElementAscendArray_With_Valid_Data()
        {
            var inputArray = MethodsForAlgorithms.GetJaggedArray();

            MethodsForAlgorithms.SortSummElementAscendArray(inputArray);

            var outputSummRowArray = MethodsForAlgorithms.SortSummDescendHelper(inputArray).Item2;

            Assert.IsTrue(MethodsForAlgorithms.SortSummAscendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortSummElementDescendArray with valid data
        /// </summary>
        /// 
        [Test]
        public void SortSummElementDescendArray_With_Valid_Data()
        {
            var inputArray = MethodsForAlgorithms.GetJaggedArray();

            MethodsForAlgorithms.SortSummElementDescendArray(inputArray);

            var outputSummRowArray = MethodsForAlgorithms.SortSummDescendHelper(inputArray).Item2;

            Assert.IsTrue(MethodsForAlgorithms.SortSummDescendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortMaxElementAscendHelper with valid data
        /// </summary>
        [Test]
        public void SortMaxElementAscendArray_With_Valid_Data()
        {
            var inputArray = MethodsForAlgorithms.GetJaggedArray();

            MethodsForAlgorithms.SortMaxElementAscendArray(inputArray);

            var outputMaxRowArray = MethodsForAlgorithms.SortSummDescendHelper(inputArray).Item2;

            Assert.IsTrue(MethodsForAlgorithms.SortMaxElementAscendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortMaxElementDescendArray with valid data
        /// </summary>
        [Test]
        public void SortMaxElementDescendArray_With_Valid_Data()
        {
            var inputArray = MethodsForAlgorithms.GetJaggedArray();

            MethodsForAlgorithms.SortMaxElementDescendArray(inputArray);

            var outputMaxRowArray = MethodsForAlgorithms.SortSummDescendHelper(inputArray).Item2;

            Assert.IsTrue(MethodsForAlgorithms.SortMaxElementDescendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortMinElementAscendArray with valid data
        /// </summary>
        [Test]
        public void SortMinElementAscendArray_With_Valid_Data()
        {
            var inputArray = MethodsForAlgorithms.GetJaggedArray();

            MethodsForAlgorithms.SortMinElementAscendArray(inputArray);

            var outputMinRowArray = MethodsForAlgorithms.SortSummDescendHelper(inputArray).Item2;

            Assert.IsTrue(MethodsForAlgorithms.SortMinElementAscendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Method for test method SortMinElementDescendArray with valid data
        /// </summary>
        [Test]
        public void SortMinElementDescendArray_With_Valid_Data()
        {
            var inputArray = MethodsForAlgorithms.GetJaggedArray();

            MethodsForAlgorithms.SortMinElementDescendArray(inputArray);

            var outputMinRowArray = MethodsForAlgorithms.SortSummDescendHelper(inputArray).Item2;

            Assert.IsTrue(MethodsForAlgorithms.SortMinElementDescendHelper(inputArray).Item1);
        }

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortSummElementAscendArray if the referenced array reference refers to null.
        /// </summary>
        [TestCase(null)]
        public void SortSummElementAscendArray_Apected_ArgumentNullException(int[][] inputArray)
            => Assert.Throws<ArgumentNullException>(() => MethodsForAlgorithms.SortSummElementAscendArray(inputArray));

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortSummElementDescendArray if the referenced array reference refers to null.
        /// </summary>
        [TestCase(null)]
        public void SortSummElementDescendArray_Apected_ArgumentNullException(int[][] inputArray)
            => Assert.Throws<ArgumentNullException>(() => MethodsForAlgorithms.SortSummElementDescendArray(inputArray));

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortMaxElementAscendArray if the referenced array reference refers to null.
        /// </summary>
        [TestCase(null)]
        public void SortMaxElementAscendArray_Apected_ArgumentNullException(int[][] inputArray)
            => Assert.Throws<ArgumentNullException>(() => MethodsForAlgorithms.SortMaxElementAscendArray(inputArray));

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortMaxElementDescendArray if the referenced array reference refers to null.
        /// </summary>
        [TestCase(null)]
        public void SortMaxElementDescendArray_Apected_ArgumentNullException(int[][] inputArray)
            => Assert.Throws<ArgumentNullException>(() => MethodsForAlgorithms.SortMaxElementDescendArray(inputArray));

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortMinElementAscendArray if the referenced array reference refers to null.
        /// </summary>
        [TestCase(null)]
        public void SortMinElementAscendArray_Apected_ArgumentNullException(int[][] inputArray)
            => Assert.Throws<ArgumentNullException>(() => MethodsForAlgorithms.SortMinElementAscendArray(inputArray));

        /// <summary>
        /// Test to check for the occurrence of an exception ArgumentNullException 
        /// in method SortMinElementDescendArray if the referenced array reference refers to null.
        /// </summary>
        [TestCase(null)]
        public void SortMinElementDescendArray_Apected_ArgumentNullException(int[][] inputArray)
            => Assert.Throws<ArgumentNullException>(() => MethodsForAlgorithms.SortMinElementDescendArray(inputArray));

        /// <summary>
        /// Test SortSummElementAscendArray if expected OverflowException
        /// </summary>
        [Test]
        public void SortSummElementAscendArray_Apected_OverflowException()
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

            Assert.Throws<OverflowException>(() => MethodsForAlgorithms.SortSummElementAscendArray(inputArray));
        }

        /// <summary>
        /// Test SortSummElementAscendArray if expected OverflowException
        /// </summary>
        [Test]
        public void SortSummElementDescendArray_Apected_OverflowException()
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

            Assert.Throws<OverflowException>(() => MethodsForAlgorithms.SortSummElementDescendArray(inputArray));
        }
    }
}
