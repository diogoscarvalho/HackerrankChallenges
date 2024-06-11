namespace MarkAndToys
{
    internal class Solution
    {
        internal static int MaximumToys(List<int> prices, int k)
        {
            int maximunToys = 0;
            int totalPrices = 0;

            prices.Sort((a, b) => {  return a.CompareTo(b); });

            for (int index = 0; index < prices.Count; index++)
            {
                if (prices[index] < k - totalPrices)
                {
                    totalPrices += prices[index];
                    maximunToys++;
                }
                else
                    break; // the array is sorted, we don't need to continue iterating over it if we prices are too high.
            }

            return maximunToys;
        }
    }
}
