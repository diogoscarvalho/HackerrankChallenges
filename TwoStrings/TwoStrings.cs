using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStrings
{
    internal static class TwoStrings
    {
        public static string twoStrings(string s1, string s2)
        {
            HashSet<char> s1UniqueChars = [];
            for (int index = 0; index < s1.Length; index++)
            {
                s1UniqueChars.Add(s1[index]);
            }

            for (int index = 0; index < s2.Length; index++)
            {
                if (s1UniqueChars.Contains(s2[index])) return "Yes";
            }

            return "No";
        }
    }
}
