using System;
using NUnit.Framework;
using Algorithms;

namespace Algorithms.Test
{
    /// <summary>
    /// Class for test Poly
    /// </summary>
    [TestFixture]
    public class PolynomialTest
    {
        /// <summary>
        /// Method for test method ToString()
        /// </summary>
        [TestCase(new double[5] { -5.0, 3.2, -4.8, 7.385, -4.5 }, "-5 3,2*x^1 -4,8*x^2 7,385*x^3 -4,5*x^4")]
        public void Override_ToString(double[] inputCoefficientArray, string result)
        {
            var polynomial = new Polynomial(inputCoefficientArray);

            var resultWas = polynomial.ToString();

            Assert.AreEqual(resultWas, result);

        }

        /// <summary>
        /// Method for test method Equals
        /// </summary>
        [TestCase(new double[5] { -5.0, 3.2, -4.8, 7.385, -4.5 }, new double[5] { -5.0, 3.2, -4.8, 7.385, -4.5 }, true)]
        [TestCase(new double[5] { -5.0, 3.2, -4.8, 7.385, -4.5 }, new double[5] { -5.0, 3.2, -4.8, 3.385, -4.5 }, false)]
        [TestCase(new double[5] { -5.0, 3.2, -4.8, 7.385, -4.5 }, new double[4] { -5.0, 3.2, -4.8, 3.385 }, false)]
        public void Override_Equals(double[] inputCoefficientArrayFirst, double[] inputCoefficientArraySecond, bool result)
        {
            var polynomialFirst = new Polynomial(inputCoefficientArrayFirst);

            var polynomialSecond = new Polynomial(inputCoefficientArraySecond);

            var resultWas = polynomialFirst.Equals(polynomialSecond);

            Assert.AreEqual(resultWas, result);
        }

        /// <summary>
        /// Method for test method GetHashCode
        /// </summary>
        [TestCase(new double[5] { -5.0, 3.2, -4.8, 7.385, -4.5 }, new double[5] { -5.0, 3.2, -4.8, 7.385, -4.5 }, true)]
        [TestCase(new double[5] { -5.0, 3.2, -4.8, 7.385, -4.5 }, new double[5] { -5.0, 3.2, -4.8, 3.385, -4.5 }, false)]
        [TestCase(new double[5] { -5.0, 3.2, -4.8, 7.385, -4.5 }, new double[4] { -5.0, 3.2, -4.8, 3.385 }, false)]
        public void Override_GetHashCode(double[] inputCoefficientArrayFirst, double[] inputCoefficientArraySecond, bool result)
        {
            var polynomialFirst = new Polynomial(inputCoefficientArrayFirst);

            var polynomialSecond = new Polynomial(inputCoefficientArraySecond);

            var hashCodeFirst = polynomialFirst.GetHashCode();

            var hashCodeSecond = polynomialSecond.GetHashCode();

            Assert.AreEqual((hashCodeFirst == hashCodeSecond), result);
        }

        /// <summary>
        /// Test method override operator +
        /// </summary>
        [TestCase(new double[5] { -5.0, 3.2, -4.8, 7.385, -4.5 }, new double[5] { -5.0, 3.2, -4.8, 7.385, -4.5 }, new double[5] { -10.0, 6.4, -9.6, 14.770, -9.0 })]
        public void Override_Overrload_Operator_Plus(double[] inputCoefficientArrayFirst, double[] inputCoefficientArraySecond, double[] result)
        {
            var polynomialFirst = new Polynomial(inputCoefficientArrayFirst);

            var polynomialSecond = new Polynomial(inputCoefficientArraySecond);

            var resultSumm = polynomialFirst + polynomialSecond;

            Assert.AreEqual(resultSumm.GetHashCode(), new Polynomial(result).GetHashCode());
        }

        /// <summary>
        /// Test method override operator -
        /// </summary>
        [TestCase(new double[5] { -5.0, 3.2, -4.8, 7.385, -4.5 }, new double[5] { -5.0, 3.0, -4.0, 7.0, -4.5 }, new double[5] { -10.0, 0.2, -0.8, 0.385, -9.0 })]
        public void Override_Overrload_Operator_Minus(double[] inputCoefficientArrayFirst, double[] inputCoefficientArraySecond, double[] result)
        {
            var polynomialFirst = new Polynomial(inputCoefficientArrayFirst);

            var polynomialSecond = new Polynomial(inputCoefficientArraySecond);

            var resultSumm = polynomialFirst - polynomialSecond;

            Assert.AreEqual(resultSumm.GetHashCode(), new Polynomial(result).GetHashCode());
        }

        /// <summary>
        /// Test method override operator *
        /// </summary>
        [TestCase(new double[5] { -5.0, 3.2, -4.8, 7.385, -4.5 }, new double[5] { -5.0, 3.0, -4.0, 7.0, -4.5 }, new double[5] { -25.0, 9.6, 19.2, 51.695, 20.25 })]
        public void Override_Overrload_Operator_Multiply(double[] inputCoefficientArrayFirst, double[] inputCoefficientArraySecond, double[] result)
        {
            var polynomialFirst = new Polynomial(inputCoefficientArrayFirst);

            var polynomialSecond = new Polynomial(inputCoefficientArraySecond);

            var resultMultiply = polynomialFirst * polynomialSecond;

            Assert.AreEqual(resultMultiply.GetHashCode(), new Polynomial(result).GetHashCode());
        }

        /// <summary>
        /// Test constructor class Polynomial if expected ArgumentNullException
        /// </summary>
        /// <param name="inputArray">input array</param>
        [TestCase(null)]
        public void Constructor_Polynomial_Expected_ArgumentNullException(double[] inputArray)
            => Assert.Throws<NullReferenceException>(() => new Polynomial(inputArray));

        /// <summary>
        /// Test GetHashCode if expected OverflowException
        /// </summary>
        /// <param name="inputArray">input array typeof double</param>
        [Test]
        public void Constructor_Polynomial_Expected_OverflowException()
        {
            Random random = new Random();

            var inputArray = new double[random.Next(1000000)];

            for(int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] = random.Next(-1000000, 1000000);
            }

            var polynomial = new Polynomial(inputArray);

            Assert.Throws<OverflowException>(() => polynomial.GetHashCode());
        }
    }
}
