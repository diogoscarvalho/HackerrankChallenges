namespace BubbleSort
{
    internal class Solution
    {
        internal static void countSwaps(List<int> a)
        {
            int totalSwaps = 0;

            for (int index = 0; index < a.Count; index++)
            {
                for (int innerIndex = index; innerIndex < (a.Count -1) - index; innerIndex++)
                {
                    if (a[innerIndex] > a[innerIndex + 1])
                    {
                        (a[innerIndex + 1], a[innerIndex]) = (a[innerIndex], a[innerIndex + 1]);
                        totalSwaps++;
                    }
                }
            }

            Console.WriteLine($"Array is sorted in {totalSwaps} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[^1]}");

        }
    }
}
