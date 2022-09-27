using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    internal class PermMissingElem
    {
        public int Solution(int[] A) 
        {
            int sum = 0;
            int sum2 = 0;
            int value = A.Min();
            for (int i = 0; i < A.Length+1; i++)
            {
                
                sum += value;
                value++;
            }
            for (int i = 0; i < A.Length; i++)
            {
          
                sum2 += A[i];
            }
            return sum - sum2;
        }
    }
}
