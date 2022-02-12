using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    public class Solution
    {
        public void HeapPermutation<T>(T[] arr, int size)
        {
            // if size becomes 1 then print the obtained
            // permutation
            if (size == 1)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < size; i++)
            {
                HeapPermutation(arr, size - 1);

                // if size is odd, swap 0th i.e (first) and
                // (size-1)th i.e (last) element
                if ((size & 1) == 1)
                {
                    Swap(ref arr[0], ref arr[size - 1]);
                }

                // If size is even, swap ith and
                // (size-1)th i.e (last) element
                else
                {
                    Swap(ref arr[i], ref arr[size - 1]);
                }
            }
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }
    }
}
