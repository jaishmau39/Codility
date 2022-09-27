using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    internal class CyclicRotation
    {
        public int[] Solution(int[] A, int K)
        {
            int[] array2 = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                int p= i+K+A.Length;
                array2[p % A.Length] = A[i];
            }
            return array2;
        }
    }
}
