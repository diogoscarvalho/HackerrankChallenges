using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort_CountingInversions
{
    internal class Solution
    {

        /*
         * Complete the 'countInversions' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static long CountInversions(List<int> arr)
        {
            long swapCounts = 0;

            var sortedList = Sort(arr, ref swapCounts);

            return swapCounts;

        }

        static List<int> Sort(List<int> arr, ref long swapCount)
        {
            if (arr.Count <= 1)
            {
                return arr;
            }

            int mid = arr.Count / 2;
            List<int> left = arr.GetRange(0, mid);
            List<int> right = arr.GetRange(mid, arr.Count - mid);

            left = Sort(left, ref swapCount);
            right = Sort(right, ref swapCount);

            return Merge(left, right, ref swapCount);
        }

        static List<int> Merge(List<int> left, List<int> right, ref long swapCount)
        {
            List<int> result = [];

            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i] <= right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    swapCount += left.Count - i;
                    j++;
                }
            }

            while (i < left.Count)
            {
                result.Add(left[i]);
                i++;
            }

            while (j < right.Count)
            {
                result.Add(right[j]);
                j++;
            }


            return result;
        }
    }
}
