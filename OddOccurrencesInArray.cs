using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    internal class OddOccurrencesInArray
    {
        public int Solution(int[] A)
        {
            Array.Sort(A);
            int counter=0;
            int j;
            for (int i = 0; i < A.Length-1; i+=2)
            {
                for (j = i+1; j < A.Length; j++)
                {
                    if (A[i] == A[j])
                    {
                        counter+=2;
                        break;
                    }
                    else
                    {
                        counter = 1;
                        break;
                    }

                }
                if(counter %2 != 0)
                {
                    return A[i];
                }
                else
                {
                    counter = 0;
                }

            }
            return 0;

        }
    }
}
