using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    public class Solution
    {
        public void HeapPermutation<T>(T[] a, int size)
        {
            // if size becomes 1 then print the obtained
            // permutation
            if (size == 1)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    Console.Write(a[j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < size; i++)
            {
                HeapPermutation(a, size - 1);

                // if size is odd, swap 0th i.e (first) and
                // (size-1)th i.e (last) element
                if ((size & 1) == 1)
                {
                    Swap(ref a[0], ref a[size - 1]);
                }

                // If size is even, swap ith and
                // (size-1)th i.e (last) element
                else
                {
                    Swap(ref a[i], ref a[size - 1]);
                }
            }
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }
    }
}
