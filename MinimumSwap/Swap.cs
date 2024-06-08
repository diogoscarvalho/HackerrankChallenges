using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumSwap
{
    internal static class Swap
    {
        public static int MinimumSwaps(int[] arr)
        {
            int swaps = 0;

            for (int index = 0; index < arr.Length; index++)
            {
                while (index + 1 != arr[index])
                {
                    int swapIndex = arr[index] - 1;
                    int valueAtIndex = arr[index];
                    int valueAtSwapIndex = arr[swapIndex];

                    arr[index] = valueAtSwapIndex;
                    arr[swapIndex] = valueAtIndex;

                    swaps++;
                }
            }

            return swaps;

        }
    }
}
