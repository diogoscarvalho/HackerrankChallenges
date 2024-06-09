namespace SherlockAndAnagrams;

public static class Anagram
{
    public static int SherlockAndAnagrams(string s)
    {
        // Hash map to store all possible substrings
        Dictionary<string, int> anagramsMap = [];
        
        // iterate over the string chars
        for(int index = 0; index < s.Length; index++){
            // Use an inner look to get the substrings
            for(int innerIndex = 1; innerIndex <= s.Length - index; innerIndex++){
                char[] substringArray = s.Substring(index, innerIndex).ToCharArray();
                Array.Sort(substringArray);
                string substring = new (substringArray);

                if(!anagramsMap.TryAdd(new string(substring), 1)){
                    anagramsMap[substring]++;
                }
            }
        }
        
        int totalAnagrams = 0;
        for(int index = 0; index < anagramsMap.Keys.Count; index++)
        {
            totalAnagrams += anagramsMap.ElementAt(index).Value * (anagramsMap.ElementAt(index).Value -1) / 2;
        }
        
        return totalAnagrams;
    }

}
