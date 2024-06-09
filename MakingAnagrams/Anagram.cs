namespace MakingAnagrams;

public static class Anagram{
    
    public static int MakeAnagram(string a, string b)
    {
        Dictionary<char, int> charMap = [];
        int necessaryDelitions = 0;

        for(int index = 0; index < a.Length; index++){
            if(!charMap.TryAdd(a[index], 1))
                charMap[a[index]]++;
        }

        for(int index = 0; index < b.Length; index++){
            if(charMap.ContainsKey(b[index]))
                charMap[b[index]]--;
            else
                necessaryDelitions++;    
        }

        foreach(var item in charMap){
            necessaryDelitions += item.Value;
        }

        return necessaryDelitions;
    }
}