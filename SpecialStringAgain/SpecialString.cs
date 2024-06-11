namespace SpecialStringAgain
{
    internal class SpecialString
    {
        internal static long SubstrCount(int n, string s)
        {
            long totalSpecialSubstrings = n;
            Dictionary<string, int> substringMap = [];

            for(int i = 0; i < n; i++)
            {
                int auxIndex = 2;
                while(auxIndex <= (n -i))
                {
                    var substring = s.Substring(i, auxIndex);
                    if (!substringMap.TryAdd(substring, 1))
                        substringMap[substring]++;

                    auxIndex++;
                }
            }

            foreach(var substring in substringMap)
            {
                if(substring.Key.Length % 2 == 0)
                {
                    for (int i = 1; i < substring.Key.Length; i++)
                    {

                        if (substring.Key[i] != substring.Key[i - 1])
                            break;

                        if (i == substring.Key.Length - 1)
                            totalSpecialSubstrings += substring.Value;

                    }
                }
                else
                {
                    bool areEqual = false;
                    if (substring.Key.Length == 3)
                    {
                        if (substring.Key[0] == substring.Key[2])
                            areEqual = true;
                    }
                    else
                    {
                        for (int i = 1; i < substring.Key.Length / 2; i++)
                        {
                            if (substring.Key[i] != substring.Key[i - 1])
                                break;

                            areEqual = true;
                        }

                        if (areEqual)
                        {
                            for (int i = substring.Key.Length -1; i > substring.Key.Length / 2; i--)
                            {
                                if (substring.Key[i] != substring.Key[i - 1])
                                {
                                    areEqual = false;
                                    break;
                                }

                                if (i == substring.Key.Length / 2)
                                    areEqual = true;
                            }
                        }
                    }

                    if(areEqual)
                        totalSpecialSubstrings += substring.Value;
                }
                
            }

            return totalSpecialSubstrings;

        }

        internal static long SubstrCount2(int n, string s)
        {

            long count = 0;
            List<(char character, int count)> charGroups = new List<(char character, int count)>();

            // Create groups of same characters with their counts
            for (int i = 0; i < n; i++)
            {
                int countChar = 1;
                while (i + 1 < n && s[i] == s[i + 1])
                {
                    countChar++;
                    i++;
                }
                charGroups.Add((s[i], countChar));
            }

            // Count substrings of type 1: all characters are the same
            foreach (var group in charGroups)
            {
                count += (group.count * (group.count + 1)) / 2;
            }

            // Count substrings of type 2: all characters except the middle one are the same
            for (int i = 1; i < charGroups.Count - 1; i++)
            {
                if (charGroups[i].count == 1 && charGroups[i - 1].character == charGroups[i + 1].character)
                {
                    count += Math.Min(charGroups[i - 1].count, charGroups[i + 1].count);
                }
            }

            return count;

        }

    }
}
