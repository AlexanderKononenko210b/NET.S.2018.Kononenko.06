using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;

namespace Algorithms.Test
{
    #region Comparers

    /// <summary>
    /// Class for compare two array by increasing the sum of elements in a row
    /// </summary>
    public class SortSummElementAscendArray : MethodsForAlgorithms.IComparerArray
    {
        public int Compare(int[] arrayLeft, int[] arrayRight)
        {
            if (arrayLeft == null && arrayRight == null)
                return 0;
            if (arrayLeft == null)
                return -1;
            if (arrayRight == null)
                return 1;
            if (arrayLeft.Length == 0 && arrayRight.Length == 0)
                return 0;
            if (arrayLeft.Length == 0)
                return -1;
            if (arrayRight.Length == 0)
                return 1;
            return arrayLeft.Sum() - arrayRight.Sum();
        }
    }

    /// <summary>
    /// Class for compare two array by descending the sum of elements in a row
    /// </summary>
    public class SortSummElementDescendArray : MethodsForAlgorithms.IComparerArray
    {
        public int Compare(int[] arrayLeft, int[] arrayRight)
        {
            if (arrayLeft == null && arrayRight == null)
                return 0;
            if (arrayLeft == null)
                return 1;
            if (arrayRight == null)
                return -1;
            if (arrayLeft.Length == 0 && arrayRight.Length == 0)
                return 0;
            if (arrayLeft.Length == 0)
                return 1;
            if (arrayRight.Length == 0)
                return -1;
            return arrayRight.Sum() - arrayLeft.Sum();
        }
    }

    /// <summary>
    /// Class for compare two array by increasing max element in a row
    /// </summary>
    public class SortMaxElementAscendArray : MethodsForAlgorithms.IComparerArray
    {
        public int Compare(int[] arrayLeft, int[] arrayRight)
        {
            if (arrayLeft == null && arrayRight == null)
                return 0;
            if (arrayLeft == null)
                return -1;
            if (arrayRight == null)
                return 1;
            if (arrayLeft.Length == 0 && arrayRight.Length == 0)
                return 0;
            if (arrayLeft.Length == 0)
                return -1;
            if (arrayRight.Length == 0)
                return 1;
            return arrayLeft.Max() - arrayRight.Max();
        }
    }

    /// <summary>
    /// Class for compare two array by descending max element in a row
    /// </summary>
    public class SortMaxElementDescendArray : MethodsForAlgorithms.IComparerArray
    {
        public int Compare(int[] arrayLeft, int[] arrayRight)
        {
            if (arrayLeft == null && arrayRight == null)
                return 0;
            if (arrayLeft == null)
                return 1;
            if (arrayRight == null)
                return -1;
            if (arrayLeft.Length == 0 && arrayRight.Length == 0)
                return 0;
            if (arrayLeft.Length == 0)
                return 1;
            if (arrayRight.Length == 0)
                return -1;
            return arrayRight.Max() - arrayLeft.Max();
        }
    }

    /// <summary>
    /// Class for compare two array by increasing min element in a row
    /// </summary>
    public class SortMinElementAscendArray : MethodsForAlgorithms.IComparerArray
    {
        public int Compare(int[] arrayLeft, int[] arrayRight)
        {
            if (arrayLeft == null && arrayRight == null)
                return 0;
            if (arrayLeft == null)
                return -1;
            if (arrayRight == null)
                return 1;
            if (arrayLeft.Length == 0 && arrayRight.Length == 0)
                return 0;
            if (arrayLeft.Length == 0)
                return -1;
            if (arrayRight.Length == 0)
                return 1;
            return arrayLeft.Min() - arrayRight.Min();
        }
    }

    /// <summary>
    /// Class for compare two array by descending min element in a row
    /// </summary>
    public class SortMinElementDescendArray : MethodsForAlgorithms.IComparerArray
    {
        public int Compare(int[] arrayLeft, int[] arrayRight)
        {
            if (arrayLeft == null && arrayRight == null)
                return 0;
            if (arrayLeft == null)
                return 1;
            if (arrayRight == null)
                return -1;
            if (arrayLeft.Length == 0 && arrayRight.Length == 0)
                return 0;
            if (arrayLeft.Length == 0)
                return 1;
            if (arrayRight.Length == 0)
                return -1;
            return arrayRight.Min() - arrayLeft.Min();
        }
    }

    #endregion
}
