using System;
using System.Text;


namespace Algorithms
{
    #region Polynomial

    public sealed class Polynomial
    {
        private readonly double[] coefficients = { };

        private readonly int[] orders = { };

        private readonly int degree;

        public static readonly double Accuracy;

        /// <summary>
        /// Degree of Polynomial
        /// </summary>
        public int Degree
        {
            get
            {
                return degree;
            }
        }

        /// <summary>
        /// Array for coefficients
        /// </summary>
        public double[] Coefficients
        {
            get
            {
                return coefficients.Clone() as double[];
            }
        }

        /// <summary>
        /// Array for orders
        /// </summary>
        public int[] Orders
        {
            get
            {
                return orders.Clone() as int[];
            }
        }

        /// <summary>
        /// Constructor class Polynomial
        /// </summary>
        /// <param name="inputArrayCoefficient">input array of coefficients</param>
        public Polynomial(double[] inputArrayCoefficient)
        {
            var inputArrayHelperCoefficient = new double[inputArrayCoefficient.Length];

            var inputArrayHelperOrder = new int[inputArrayCoefficient.Length];

            int indexHelperArray = 0;

            for (int i = 0; i < inputArrayCoefficient.Length; i++)
            {
                if (Math.Abs(inputArrayCoefficient[i]) > Accuracy)
                {
                    inputArrayHelperCoefficient[indexHelperArray] = inputArrayCoefficient[i];

                    inputArrayHelperOrder[indexHelperArray] = i;

                    indexHelperArray++;
                }
            }

            this.coefficients = inputArrayHelperCoefficient;

            this.orders = inputArrayHelperOrder;

            this.degree = this.Orders[indexHelperArray-1];
        }

        /// <summary>
        /// Static constructor Polynomial
        /// </summary>
        static Polynomial()
        {
            try
            {
                var appSettingsReader = new System.Configuration.AppSettingsReader();

                Accuracy = (double)appSettingsReader.GetValue("accuracy", typeof(double));
            }
            catch(Exception)
            {
                Accuracy = 0.000001;
            }
        }



        /// <summary>
        /// Override method ToSring class object
        /// </summary>
        /// <returns>string performance object</returns>
        public override string ToString()
        {
            if (this.Coefficients.Length == 0 || this.Coefficients.Length == 1)
            {
                throw new ArgumentOutOfRangeException($"Array of coefficients must have > 1 elements");
            }

            StringBuilder helperForToString = new StringBuilder();

            helperForToString.Append($"{Coefficients[0]}");

            for (int i = 1; i < Coefficients.Length; i++)
            {
                helperForToString.Append($" {Coefficients[i]}*x^{Orders[i]}");
            }

            return helperForToString.ToString();
        }

        /// <summary>
        /// Override method Equals for two Polynomial
        /// </summary>
        /// <param name="obj">second object for operation equals</param>
        /// <returns></returns>
        public bool Equals(Polynomial polynomial)
        {
            if (ReferenceEquals(null, polynomial))
                return false;

            if (ReferenceEquals(this, polynomial))
                return false;

            if (this.Orders.Length != polynomial.Orders.Length)
                return false;

            if (this.Degree != polynomial.Degree)
                return false;

            for(int i = 0; i < this.Orders.Length; i++)
            {
                if(this.Orders[i] == polynomial.Orders[i])
                {
                    if (this.Coefficients[i] != polynomial.Coefficients[i])
                        return false;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Override method Equals for two object
        /// </summary>
        /// <param name="obj">second object for operation equals</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;

            if (ReferenceEquals(this, obj)) return false;

            if (obj.GetType() != this.GetType()) return false;

            return Equals((Polynomial) obj);
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
                    hashCode *= (int)Math.Abs(this.Coefficients[i]);
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
        public static  Polynomial operator +(Polynomial first, Polynomial second)
        {
            if (first == null)
            {
                throw new ArgumentNullException($"Argument {nameof(first)} is null");
            }

            if (second == null)
            {
                throw new ArgumentNullException($"Argument {nameof(second)} is null");
            }

            var resultArray = AdditionAndSubtractionHelper(first.Coefficients, first.Orders, second.Coefficients, second.Orders);

            var resultPolynomial = new Polynomial(resultArray);

            return resultPolynomial;
        }



        /// <summary>
        /// Method for override operation -
        /// </summary>
        /// <param name="first">first object type Polynomial</param>
        /// <param name="second">second object type Polynomial</param>
        /// <returns>result object Polynomial</returns>
        public static Polynomial operator - (Polynomial first, Polynomial second)
        {
            if(first == null)
            {
                throw new ArgumentNullException($"Argument {nameof(first)} is null");
            }

            if (second == null)
            {
                throw new ArgumentNullException($"Argument {nameof(second)} is null");
            }

            var secondOther = second.Coefficients.Clone() as double[];

            for(int i = 0; i < second.Orders.Length; i++)
            {
                secondOther[i] = - secondOther[i];
            }

            var resultArray = AdditionAndSubtractionHelper(first.Coefficients, first.Orders, secondOther, second.Orders);

            var resultPolynomial = new Polynomial(resultArray);

            return resultPolynomial;
        }

        /// <summary>
        /// Helper method for operation + and -
        /// </summary>
        /// <param name="first">first object type Polynomial</param>
        /// <param name="second">second object type Polynomial</param>
        /// <returns>result double[]</returns>
        private static double[] AdditionAndSubtractionHelper(double[] firstCoefficients, int[] firstOrders, double[] secondCoefficients, int[] secondOrders)
        {
            var maxDegree = (firstOrders.Length > secondOrders.Length) ? firstOrders.Length : secondOrders.Length;

            var helperArrayCoefficients = new double[maxDegree + 1];

            int indexFirst = 0, indexSecond = 0;

            for (int i = 0; i < helperArrayCoefficients.Length; i++)
            {
                if(indexFirst < firstCoefficients.Length && indexSecond < secondCoefficients.Length)
                {
                    if (i == firstOrders[indexFirst] && i == secondOrders[indexSecond])
                    {
                        helperArrayCoefficients[i] = firstCoefficients[indexFirst] + secondCoefficients[indexSecond];
                        indexFirst++; indexSecond++;
                    }
                    else
                    {
                        if (i != firstOrders[indexFirst] && i == secondOrders[indexSecond])
                        {
                            helperArrayCoefficients[i] = + secondCoefficients[indexSecond];
                            indexSecond++;
                        }
                        else
                        {
                            if (i == firstOrders[indexFirst] && i != secondOrders[indexSecond])
                            {
                                helperArrayCoefficients[indexFirst] = firstCoefficients[i];
                                indexFirst++;
                            }
                            else
                            {
                                helperArrayCoefficients[i] = 0;
                            }
                        }
                    }
                }
                else
                {
                    if (i < firstCoefficients.Length && i >= secondCoefficients.Length)
                    {
                        if (i == firstOrders[indexFirst])
                        {
                            helperArrayCoefficients[i] = firstCoefficients[indexFirst];
                            indexFirst++;
                        }
                        else
                        {
                            helperArrayCoefficients[i] = 0;
                        }
                    }
                    else
                    {
                        if (i >= firstCoefficients.Length && i < secondCoefficients.Length)
                        {
                            if (i == secondOrders[indexSecond])
                            {
                                helperArrayCoefficients[i] = secondCoefficients[indexSecond];
                                indexSecond++;
                            }
                            else
                            {
                                helperArrayCoefficients[i] = 0;
                            }
                        }
                        else
                        {
                            helperArrayCoefficients[i] = 0;
                        }
                    }
                }
            }

            return helperArrayCoefficients;
        }

        /// <summary>
        /// Method for override operation *
        /// </summary>
        /// <param name="first">first object type Polynomial</param>
        /// <param name="second">second object type Polynomial</param>
        /// <returns>result object Polynomial</returns>
        public static Polynomial operator *(Polynomial first, Polynomial second)
        {
            var maxDegree = (first.Orders.Length > second.Orders.Length) ? first.Orders.Length : second.Orders.Length;

            var helperArrayCoefficients = new double[maxDegree + 1];

            int indexFirst = 0, indexSecond = 0;

            for (int i = 0; i < helperArrayCoefficients.Length; i++)
            {
                if (indexFirst < first.Coefficients.Length && indexSecond < second.Coefficients.Length)
                {
                    if (i == first.Orders[indexFirst] && i == second.Orders[indexSecond])
                    {
                        helperArrayCoefficients[i] = first.Coefficients[indexFirst] * second.Coefficients[indexSecond];
                        indexFirst++; indexSecond++;
                    }
                    else
                    {
                        if (i != first.Orders[indexFirst] && i == second.Orders[indexSecond])
                        {
                            indexSecond++;
                        }
                        else
                        {
                            if (i == first.Orders[indexFirst] && i != second.Orders[indexSecond])
                            {
                                indexFirst++;
                            }
                        }

                        helperArrayCoefficients[i] = 0;
                    }
                }
                else
                {
                    if (i < first.Coefficients.Length && i >= second.Coefficients.Length)
                    {
                        if (i == first.Orders[indexFirst])
                        {
                            indexFirst++;
                        }
                    }
                    else
                    {
                        if (i >= first.Coefficients.Length && i < second.Coefficients.Length)
                        {
                            if (i == second.Orders[indexSecond])
                            {
                                indexSecond++;
                            }
                        }
                    }

                    helperArrayCoefficients[i] = 0;
                }
            }

            var resultPolynomial = new Polynomial(helperArrayCoefficients);

            return resultPolynomial;
        }
    }

    #endregion Polynomial
}
