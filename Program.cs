using Codility;
using System;

namespace Codility
{

    internal class Program
    {
        public static void Main(string[] args)
        {
            //binary Gap
            //var sl = new BinaryGap();
            //Console.WriteLine(sl.Solution(529));

            //cyclicrotation
            //var sl1 = new CyclicRotation();
            //Console.WriteLine(string.Join(",", sl1.Solution(new int[] { 2, 3, 5, 7 }, 3)));

            //PermMissingElem
            var sl2 = new PermMissingElem();
            Console.WriteLine(sl2.Solution(new int[] {2,3,1,5}));
        }
    }
}