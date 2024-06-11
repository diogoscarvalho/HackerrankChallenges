namespace AlternatingCharacteres
{
    internal class Solution
    {
        internal static int alternatingCharacters(string s)
        {
            int totalDelitions = 0;

            for (int index = 1; index < s.Length; index++)
            {
                if (s[index] == s[index - 1]) totalDelitions++;
            }

            return totalDelitions;
        }
    }
}
