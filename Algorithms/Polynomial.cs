using System;
using System.Text;


namespace Algorithms
{
    #region Polynomial

    public sealed class Polynomial
    {
        private const double EPSILON = double.Epsilon;

        private double[][] coefficients;

        /// <summary>
        /// Degree of Polynomial
        /// </summary>
        public int Degree { get; }

        /// <summary>
        /// Jagged array for coefficients
        /// </summary>
        public double[][] Coefficients
        {
            get
            {
                if (coefficients == null)
                {
                    coefficients = new double[1][];
                }

                return coefficients;
            }

            set
            {
                coefficients = value;
            }
        }

        /// <summary>
        /// Constructor class Polynomial
        /// </summary>
        /// <param name="inputArrayCoefficient">input array of coefficients</param>
        public Polynomial(double[] inputArrayCoefficient)
        {
            this.Coefficients[0] = inputArrayCoefficient;

            this.Degree = Coefficients[0].Length - 1;
        }

        /// <summary>
        /// Override method ToSring class object
        /// </summary>
        /// <returns>string performance object</returns>
        public override string ToString()
        {
            if (this.Coefficients[0].Length == 0 || this.Coefficients[0].Length == 1)
            {
                throw new ArgumentOutOfRangeException($"Array of coefficients mast have > 1 elements");
            }

            StringBuilder helperForToString = new StringBuilder();

            helperForToString.Append($"{Coefficients[0][0]}");

            for (int i = 1; i < Coefficients[0].Length; i++)
            {
                helperForToString.Append($" {Coefficients[0][i]}*x^{i}");
            }

            return helperForToString.ToString();
        }

        /// <summary>
        /// Override method Equals for two object Polynomial
        /// </summary>
        /// <param name="obj">second object for operation equals</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var secondPolynomialForEquals = obj as Polynomial;

            if (secondPolynomialForEquals?.Degree != this.Degree)
            {
                return false;
            }

            for (int i = 0; i <= this.Degree; i++)
            {
                if (Math.Abs(this.Coefficients[0][i] - secondPolynomialForEquals.Coefficients[0][i]) > EPSILON)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Override method GetHashCode
        /// </summary>
        /// <returns>hash code</returns>
        public override int GetHashCode()
        {
            var hashCode = Degree;

            for (int i = this.Degree; i >= 0; i--)
            {
                checked
                {
                    hashCode *= (int)Math.Abs(this.Coefficients[0][i]);
                }
            }

            return hashCode;
        }

        /// <summary>
        /// Method for override operation +
        /// </summary>
        /// <param name="first">first object type Polynomial</param>
        /// <param name="second">second object type Polynomial</param>
        /// <returns>result object Polynomial</returns>
        public static Polynomial operator +(Polynomial first, Polynomial second)
        {
            var degreeResultMin = (first.Degree < second.Degree) ? first.Degree : second.Degree;

            var degreeResulMax = (first.Degree > second.Degree) ? first.Degree : second.Degree;

            var resultArray = new double[degreeResulMax + 1];

            for (int i = 0; i <= degreeResultMin; i++)
            {
                resultArray[i] = first.Coefficients[0][i] + second.Coefficients[0][i];
            }

            if (first.Degree == second.Degree)
            {
                if (first.Degree < second.Degree)
                    Array.Copy(second.Coefficients[0], degreeResultMin + 1, resultArray, degreeResultMin + 1, second.Coefficients[0].Length - resultArray.Length);
                else
                    Array.Copy(first.Coefficients[0], degreeResultMin + 1, resultArray, degreeResultMin + 1, second.Coefficients[0].Length - resultArray.Length);
            }

            return new Polynomial(resultArray);
        }

        /// <summary>
        /// Method for override operation -
        /// </summary>
        /// <param name="first">first object type Polynomial</param>
        /// <param name="second">second object type Polynomial</param>
        /// <returns>result object Polynomial</returns>
        public static Polynomial operator -(Polynomial first, Polynomial second)
        {
            var degreeResultMin = (first.Degree < second.Degree) ? first.Degree : second.Degree;

            var degreeResulMax = (first.Degree > second.Degree) ? first.Degree : second.Degree;

            var resultArray = new double[degreeResulMax + 1];

            for(int i = 0; i <= degreeResultMin; i++)
            {
                resultArray[i] = first.Coefficients[0][i] - second.Coefficients[0][i];
            }

            if(first.Degree == second.Degree)
            {
                if (first.Degree < second.Degree)
                    Array.Copy(second.Coefficients[0], degreeResultMin + 1, resultArray, degreeResultMin + 1, second.Coefficients[0].Length - resultArray.Length);
                else
                    Array.Copy(first.Coefficients[0], degreeResultMin + 1, resultArray, degreeResultMin + 1, second.Coefficients[0].Length - resultArray.Length);
            }

            return new Polynomial(resultArray);
        }

        /// <summary>
        /// Method for override operation *
        /// </summary>
        /// <param name="first">first object type Polynomial</param>
        /// <param name="second">second object type Polynomial</param>
        /// <returns>result object Polynomial</returns>
        public static Polynomial operator *(Polynomial first, Polynomial second)
        {
            var degreeResultMin = (first.Degree < second.Degree) ? first.Degree : second.Degree;

            var degreeResulMax = (first.Degree > second.Degree) ? first.Degree : second.Degree;

            var resultArray = new double[degreeResulMax + 1];

            for (int i = 0; i <= degreeResultMin; i++)
            {
                resultArray[i] = first.Coefficients[0][i] * second.Coefficients[0][i];
            }

            if (first.Degree == second.Degree)
            {
                if (first.Degree < second.Degree)
                    Array.Copy(second.Coefficients[0], degreeResultMin + 1, resultArray, degreeResultMin + 1, second.Coefficients[0].Length - resultArray.Length);
                else
                    Array.Copy(first.Coefficients[0], degreeResultMin + 1, resultArray, degreeResultMin + 1, second.Coefficients[0].Length - resultArray.Length);
            }

            return new Polynomial(resultArray);
        }
    }

    #endregion Polynomial
}
