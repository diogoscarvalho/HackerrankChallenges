using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.com
{
    internal class FirstChallenge
    {
        [Benchmark]
        public static int CountDuplicate(List<int> numbers)
        {
            int totalDuplicates = 0;
            var distinctNumbers = numbers.Distinct().ToList();

            HashSet<int> uniqueNumbers = new HashSet<int>();
            HashSet<int> countedNumbers = new HashSet<int>();

            if (distinctNumbers.Count == numbers.Count) return totalDuplicates;

            for (int index = 0; index < numbers.Count; index++)
            {
                if (!uniqueNumbers.Add(numbers[index]) && countedNumbers.Add(numbers[index]))
                {
                    totalDuplicates++;
                }
            }

            return totalDuplicates;
        }

        [Benchmark]
        public static int CountDuplicateWithDictionary(List<int> numbers)
        {
            int totalDuplicates = 0;
            var distinctNumbers = numbers.Distinct().ToList();

            Dictionary<int, int> counts = [];

            if (distinctNumbers.Count == numbers.Count) return totalDuplicates;

            for (int index = 0; index < numbers.Count; index++)
            {
                if (!counts.TryAdd(numbers[index], 1))
                {
                    if (counts[numbers[index]] == 1)
                        totalDuplicates++;

                    counts[numbers[index]] += 1;
                }
            }

            return totalDuplicates;
        }
    }
}
