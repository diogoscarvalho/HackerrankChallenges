namespace BestTimetoBuyandSellStockII
{
    public static class Solution
    {
        public static int MaxProfit(int[] prices)
        {
            int minValue = prices[0];
            int profit = 0;
            bool traded = false;
            for(int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minValue || traded)
                {
                    minValue = prices[i];
                    traded = false;
                    continue;
                }

                if (i == prices.Length - 1 || prices[i] > prices[i +1])
                {
                    profit += prices[i] - minValue;
                    traded = true;
                }
            }

            return profit;
        }
    }
}
