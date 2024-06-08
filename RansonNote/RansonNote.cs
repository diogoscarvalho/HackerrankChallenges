namespace TwoStrings
{
    internal static class RansonNote
    {
        public static void CheckMagazine(List<string> magazine, List<string> note)
        {
            if (magazine.Count < note.Count) { Console.WriteLine("No"); return; }
            Dictionary<string, int> magazineHashTable = [];

            for (int index = 0; index < magazine.Count; index++)
            {
                if (!magazineHashTable.TryAdd(magazine[index], 1)) magazineHashTable[magazine[index]]++;
            }

            for (int index = 0; index < note.Count; index++)
            {
                if (magazineHashTable.TryGetValue(note[index], out int ocurrencies) && ocurrencies > 0)
                {
                    magazineHashTable[note[index]]--;
                    continue;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
