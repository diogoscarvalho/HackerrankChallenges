using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HIndex
{
    internal static class Solution
    {
        public static int HIndex(int[] citations)
        {
            int nrCitations = 0;
            Array.Sort(citations, (a, b) => b.CompareTo(a));

            for (int index = 0; index < citations.Length -1; index++)
            {
                if (citations[index] > index) nrCitations++;
                else break;
            }

            return nrCitations;
        }
    }
}
