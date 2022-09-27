using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    internal class BinaryGap
    {
        int value1;
        int value2;
        //int[] arr1;
        
        public int Solution(int N)
        {
            int counter = 0;
            var binary = Convert.ToString(N, 2);

            List<int> ls = new List<int>();
            ls.Add(0);

            for (int i=0; i<binary.Length; i++)
            {
                if(binary[i] == '1' && counter != 1)
                {
                    counter++; value1 = i+1;
                }
                else if (binary[i] == '1' && counter == 1)
                {
                    counter++;
                    value2 = i;
                    int value = value2 - value1;
                    ls.Add(value);
                    //arr1 = new int[] { value };
                    counter = 1;
                    value1 = value2+1;
                }
            }
           
                return ls.Max();
            
        }
    }
}
