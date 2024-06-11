namespace Comparator
{
    internal class Solution
    {
        internal static void Sort(List<KeyValuePair<string, int>> players)
        {
            QuickSort(players, 0, players.Count -1);
            
            foreach (var p in players)
            {
                Console.WriteLine($"{p.Key} {p.Value}");
            }

        }

        // Quick sort implementation
        static void QuickSort(List<KeyValuePair<string, int>> list, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(list, left, right);
                QuickSort(list, left, pivotIndex - 1);
                QuickSort(list, pivotIndex + 1, right);
            }
        }

        static int Partition(List<KeyValuePair<string, int>> list, int left, int right)
        {
            int mid = left + (right - left) / 2;
            var pivot = list[mid];

            Swap(list, mid, right);

            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (list[j].Value > pivot.Value 
                    || (string.Compare(list[j].Key, pivot.Key) < 0 && list[j].Value == pivot.Value))
                {
                    i++;
                    Swap(list, i, j);
                }
            }

            Swap(list, i + 1, right);
            return i + 1;
        }

        static void Swap(List<KeyValuePair<string, int>> list, int i, int j)
        {
            (list[j], list[i]) = (list[i], list[j]);
        }
    }
}
