using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Interface for compare two array in jagged array
    /// </summary>
    public interface IComparerArray
    {
        int Compare(int[] arrayLeft, int[] arrayRight);
    }
}
