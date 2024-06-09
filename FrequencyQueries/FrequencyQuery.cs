namespace FrequencyQueries;

public static class FrequencyQuery
{
    public static List<int> FreqQuery(List<List<int>> queries) {
        Dictionary<int, int> valCounts = new Dictionary<int, int>();
        Dictionary<int, int> frequencyCounts = new Dictionary<int, int>();
        List<int> results = new List<int>();

        foreach (var query in queries)
        {
            int type = query[0];
            int val = query[1];

            switch (type)
            {
                case 1:
                    if (valCounts.ContainsKey(val))
                    {
                        if (frequencyCounts.ContainsKey(valCounts[val]))
                        {
                            frequencyCounts[valCounts[val]]--;
                        }
                        valCounts[val]++;
                    }
                    else
                    {
                        valCounts[val] = 1;
                    }

                    if (frequencyCounts.ContainsKey(valCounts[val]))
                    {
                        frequencyCounts[valCounts[val]]++;
                    }
                    else
                    {
                        frequencyCounts[valCounts[val]] = 1;
                    }
                    break;

                case 2:
                    if (valCounts.ContainsKey(val) && valCounts[val] > 0)
                    {
                        if (frequencyCounts.ContainsKey(valCounts[val]))
                        {
                            frequencyCounts[valCounts[val]]--;
                        }
                        valCounts[val]--;

                        if (frequencyCounts.ContainsKey(valCounts[val]))
                        {
                            frequencyCounts[valCounts[val]]++;
                        }
                        else
                        {
                            frequencyCounts[valCounts[val]] = 1;
                        }
                    }
                    break;

                case 3:
                    if (frequencyCounts.ContainsKey(val) && frequencyCounts[val] > 0)
                        results.Add(1);
                    else
                        results.Add(0);
                    break;
            }
        }

        return results;
    }
}
