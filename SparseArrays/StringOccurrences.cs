using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SparseArrays
{
    internal class StringOccurrences
    {
        public static List<int> MatchingStrings(List<string> stringList, List<string> queries)
        {
            List<int> result = [];
            Dictionary<string, int> occurrencies = new();

            for (int j = 0; j < stringList.Count; j++)
            {
                if(!occurrencies.TryAdd(stringList[j], 1))
                {
                    occurrencies[stringList[j]]++;
                }
            }

            for (int i = 0; i < queries.Count; i++)
            {
                if (occurrencies.TryGetValue(queries[i], out int ocurrence))
                {
                    result.Add(ocurrence);
                }
                else
                    result.Add(0);
            }

            return result;
        }
    }
}
