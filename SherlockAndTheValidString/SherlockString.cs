namespace SherlockAndTheValidString
{
    internal static class SherlockString
    {
        internal static string IsValid(string s)
        {
            Dictionary<char, int> charCountMap = [];
            Dictionary<int, int> frequencyCountMap = [];

            for (int index = 0; index < s.Length; index++)
            {
                if (charCountMap.TryGetValue(s[index], out int charCount))
                {
                    if (frequencyCountMap.TryGetValue(charCount, out int frequency))
                    {
                        if(frequency > 1)
                            frequencyCountMap[charCount]--;
                        else
                            frequencyCountMap.Remove(charCount);

                        charCountMap[s[index]]++;
                    }
                }
                else
                {
                    charCountMap[s[index]] = 1;
                }

                if (frequencyCountMap.TryGetValue(charCountMap[s[index]], out _))
                {
                    frequencyCountMap[charCountMap[s[index]]]++;
                }
                else
                {
                    frequencyCountMap[charCountMap[s[index]]] = 1;
                }
            }

            int frequenciesCount = frequencyCountMap.Count;

            switch (frequenciesCount)
            {
                case 1:
                    return "YES";
                case 2:
                    var item = frequencyCountMap.ElementAt(0);
                    var item2 = frequencyCountMap.ElementAt(1);

                    if (item.Value > 1 && item2.Value > 1) return "NO";
                    if ((item.Value == 1 && item.Key == 1) || (item2.Value == 1 && item2.Key == 1)) return "YES";
                    if (Math.Abs(item.Key - item2.Key) == 1 && (item.Value == 1 || item2.Value == 1)) return "YES";
                    else
                        return "NO";
                    
                default:
                    return "NO";
            }
        }
    }
}
