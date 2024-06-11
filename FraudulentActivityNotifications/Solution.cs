using System.Collections.Concurrent;
using System.Security.AccessControl;

namespace FraudulentActivityNotifications
{
    internal class Solution
    {
        public static int activityNotifications(List<int> expenditures, int d)
        {
            var sortedExpeditureFrequencies = new SortedDictionary<int, int>();
            for (int i = 0; i < d; i++)
            {
                var expenditure = expenditures[i];

                if (!sortedExpeditureFrequencies.TryAdd(expenditure, 1)) 
                    sortedExpeditureFrequencies[expenditure]++;
            }
            var numNotifications = 0;
            for (var i = d; i < expenditures.Count; i++)
            {
                var median = GetMedian(sortedExpeditureFrequencies, d);

                if (expenditures[i] >= 2 * median) 
                    numNotifications++;

                var valToDrop = expenditures[i - d];
                var valToDropFreq = sortedExpeditureFrequencies[valToDrop];

                if (valToDropFreq == 1) 
                    sortedExpeditureFrequencies.Remove(valToDrop);
                else 
                    sortedExpeditureFrequencies[valToDrop]--;

                if (i < expenditures.Count - 1)
                {
                    var valToAdd = expenditures[i];
                    if (!sortedExpeditureFrequencies.TryAdd(valToAdd, 1))
                        sortedExpeditureFrequencies[valToAdd]++;
                }
            }
            return numNotifications;
        }

        public static decimal GetMedian(SortedDictionary<int, int> frequenciesMap, int period)
        {
            var numCases = 0;
            var keys = frequenciesMap.Keys.ToArray();
            
            // Period is Odd
            if (period % 2 != 0)
            {
                var medianIndex = period / 2;
                for (var frequencyIndex = 0; frequencyIndex < frequenciesMap.Count; frequencyIndex++)
                {
                    var curValue = frequenciesMap[keys[frequencyIndex]];
                    numCases += curValue;

                    if (numCases > medianIndex) 
                        return keys[frequencyIndex];
                }
            }

            // Period is even
            var rightIndex = period / 2;
            var leftIndex = rightIndex - 1;
            var leftValue = 0;
            var rightValue = 0;

            var leftIndexSet = false;
            for (var frequencyIndex = 0; frequencyIndex < frequenciesMap.Count; frequencyIndex++)
            {
                var curValue = frequenciesMap[keys[frequencyIndex]];
                numCases += curValue;

                if (numCases > leftIndex)
                {
                    if (!leftIndexSet)
                    {
                        leftValue = keys[frequencyIndex];
                        leftIndexSet = true;

                        if (numCases > rightIndex)
                        {
                            rightValue = leftValue;
                            break;
                        }
                    }
                    else if (numCases > rightIndex)
                    {
                        rightValue = keys[frequencyIndex]; break;
                    }
                }
            }
            return ((decimal)leftValue + rightValue) / 2;

        }
    }
}
